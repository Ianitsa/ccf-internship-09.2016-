using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NHotkey.Wpf;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using BookmarkManagerDesktop;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace BookmarkManager
{
    public partial class MainWindow : Window
    {

        public List<string> ContentAssistSource
        {
            get { return (List<string>)GetValue(ContentAssistSourceProperty); }
            set { SetValue(ContentAssistSourceProperty, value); }
        }
        public string tagGetter()
        {
        FlowDocument doc = Tokenizer.Document as FlowDocument;
        TextRange range = new TextRange(doc.ContentStart, doc.ContentEnd);
        List<string> tags = range.Start.Paragraph.Inlines.OfType<InlineUIContainer>().Select(c => c.Child).OfType<ContentPresenter>().Select(c => c.Content).OfType<string>().ToList();

        string tagText = string.Join(";", tags.ToArray());
        return tagText;

        }

       //static  FlowDocument doc = Tokenizer.Document as FlowDocument;
       // FlowDocument range = new TextRange(doc.ContentStart, doc.ContentEnd);
       // public List<string> tags {
       //     set{
       //     range.Start.Paragraph.Inlines.OfType<InlineUIContainer>().Select(c => c.Child).OfType<ContentPresenter>().Select(c => c.Content).OfType<string>().ToList();
       //     }

        // Using a DependencyProperty as the backing store for ContentAssisteSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentAssistSourceProperty =
            DependencyProperty.Register("ContentAssistSource", typeof(List<string>), typeof(MainWindow), new UIPropertyMetadata(new List<string>()));

        public List<char> ContentAssistTriggers
        {
            get { return (List<char>)GetValue(ContentAssistTriggersProperty); }
            set { SetValue(ContentAssistTriggersProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ContentAssistTriggers.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentAssistTriggersProperty =
            DependencyProperty.Register("ContentAssistTriggers", typeof(List<char>), typeof(MainWindow), new UIPropertyMetadata(new List<char>()));

        public MainWindow()
        {
            HotkeyManager.Current.AddOrReplace("Close", Key.Q, ModifierKeys.Control | ModifierKeys.Shift, OnHideKeyPressed);
            HotkeyManager.Current.AddOrReplace("Show", Key.Q, ModifierKeys.Control, OnShowKeyPressed);

            InitializeComponent();

            Button btn = new Button();
            btn.Name = "OpenFromTray";
            OpenFromTray.Click += OpenFromTray_Click;

            InitRichTextBoxSource();
            InitRichTextBoxIntellisenseTrigger();
            Tokenizer.Focus();
            DataContext = this;
        }

        private void InitRichTextBoxIntellisenseTrigger()
        {
            ContentAssistTriggers.Add('@');
        }

        private void InitRichTextBoxSource()
        {
            BookmarkManagerDesktop.BookmarkManager bookmarkManager = new BookmarkManagerDesktop.BookmarkManager();

            List<Tag> bmt = bookmarkManager.GetAllTags();

            foreach (var tag in bmt)
            {
                ContentAssistSource.Add(tag.TagName);
            }
        }

        private void OpenFromTray_Click(object sender, RoutedEventArgs e)
        {
            Window.Show();
        }

        private void OnHideKeyPressed(object sender, NHotkey.HotkeyEventArgs e)
        {
            Window.Hide();
        }
        bool _IsEmpty = true;
        private void OnShowKeyPressed(object sender, NHotkey.HotkeyEventArgs e)
        {
            Window.Show();
        }

        public void FieldStatusImage(bool status)
        {
            if (status == true)
            {
                linkStatusA.Visibility = Visibility.Visible;
                linkStatusD.Visibility = Visibility.Hidden;
            }
            else
            {
                linkStatusD.Visibility = Visibility.Visible;
                linkStatusA.Visibility = Visibility.Hidden;
            }
        }

        public void TagStatusImage(bool status)
        {
            if (status == true)
            {
                tagStatusA.Visibility = Visibility.Visible;
                tagStatusD.Visibility = Visibility.Hidden;
            }
            else
            {
                tagStatusD.Visibility = Visibility.Visible;
                tagStatusA.Visibility = Visibility.Hidden;
            }
        }

        private void linkValidation(object sender, TextChangedEventArgs e)
        {
            Validation();
        }

        private bool Validation()
        {

            bool x = false;
            Uri uriResult;
            bool result = Uri.TryCreate(linkBox.Text, UriKind.Absolute, out uriResult)
                      && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (result)
            {
                if (tagStatusA.Visibility == Visibility.Visible)
                {
                    addBtn.IsEnabled = true;
                }
                x = true;
                FieldStatusImage(x);
                return true;
            }
            else
            {
                x = false;
                FieldStatusImage(x);

                addBtn.IsEnabled = false;
                return false;
            }

        }

        private void AddButton(object sender, RoutedEventArgs e)
        {
            if (!Validation())
            {
                MessageBox.Show("Incorect input", "Error", MessageBoxButton.OK);
            }
            else
            {
                //BookmarkManagerDesktop.Configuration.ConnectionString = Configuration.ConnectionString;
                BookmarkManagerDesktop.BookmarkManager bookmarkManager = new BookmarkManagerDesktop.BookmarkManager();

                string url = Uri.EscapeUriString(linkBox.Text.ToString());
                string description = textDescription.Text.ToString();
                                
                //Tokenizer.Document = flowDoc;


                string tagText = tagGetter();
                if (string.IsNullOrWhiteSpace(tagText))
                {
                    _IsEmpty = true;
                }
                bool isAdded = bookmarkManager.InsertData(url, description, tagText);
                if (isAdded)
                {
                    MessageBoxResult result = MessageBox.Show("Do you want to save the html from the current link?", "Message", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        gethtml();
                    }
                    linkBox.Clear();
                    textDescription.Clear();
                    Tokenizer.Document.Blocks.Clear();
                }
                else
                {
                    MessageBox.Show("Connection error", "Error", MessageBoxButton.OK);
                    
                }

            }
        }

        private void gethtml()
        {
            try
            {
                using (WebResponse wr = WebRequest.Create(linkBox.Text).GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream()))
                    {
                        BookmarkManagerDesktop.BookmarkManager bookmarkManager = new BookmarkManagerDesktop.BookmarkManager();
                        string someString = sr.ReadToEnd();
                        bookmarkManager.InsertHTML(linkBox.Text, someString);
                        MessageBox.Show("The HTML from the link you've entered has been saved.", "Success!", MessageBoxButton.OK);
                    }
                }
            }
            catch (Exception)
            {
                linkBox.Focus();
                MessageBox.Show("The link is invalid or there is no connection to the entered link.", "Connection error", MessageBoxButton.OK);
            }
        }

        private List<Bookmark> _Bookmarks = new List<Bookmark>();
        private void SearchTagsAndPublishedBy(object sender, RoutedEventArgs e)
        {
            //BookmarkManagerDesktop.Entrance.ConnectionString = Configuration.ConnectionString;
            BookmarkManagerDesktop.BookmarkManager bookmarkManager = new BookmarkManagerDesktop.BookmarkManager();
            string searchText = textSearch.Text.ToString();
            _Bookmarks = bookmarkManager.GetUrl(searchText);
            DataContext = _Bookmarks;
        }

        private void tagValidation(object sender, TextChangedEventArgs e)
        {

            Loaded += delegate
            {
                Tokenizer.Focus();
            };

            Tokenizer.TokenMatcher = text =>
            {
                if (text.EndsWith(";") || text.EndsWith(","))
                {
                    string pureTag = text.Substring(0, text.Length - 1);
                    if ((string.IsNullOrWhiteSpace(pureTag)) || pureTag.Contains(",") || pureTag.Contains(";"))
                    {
                        MessageBox.Show("Please enter a correct input. ';' and ',' are only used for delimeters. ", "Error", MessageBoxButton.OK);
                        tagStatusA.Visibility = Visibility.Hidden;
                        tagStatusD.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        tagStatusA.Visibility = Visibility.Visible;
                        tagStatusD.Visibility = Visibility.Hidden;
                        if (Validation())
                        {
                            addBtn.IsEnabled = true;
                        }
                        else
                        {
                            addBtn.IsEnabled = false;
                        }
                        // Remove the ';'
                        // Remove the ','
                        if (text.Contains("@"))
                        {
                            return text.Substring(0, text.Length - 1).TrimStart('@');
                        }
                        else
                        {
                            return text.Substring(0, text.Length - 1).Trim().ToUpper();
                        }
                    }
                }
                else if (string.IsNullOrWhiteSpace(tagGetter()))
                {
                    tagStatusA.Visibility = Visibility.Hidden;
                    tagStatusD.Visibility = Visibility.Visible;
                    addBtn.IsEnabled = false;
                }
                
                
                return null;
            };
        }

        private void textSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textSearch.Text) || textSearch.Text.Contains("'") || textSearch.Text.Contains("*"))
            {
                searchBtn.IsEnabled = false;
            }
            else
            {
                searchBtn.IsEnabled = true;
            }
        }

        private void Enter(object sender, KeyEventArgs e)
        {
            if (searchBtn.IsEnabled == true)
            {
                SearchTagsAndPublishedBy(sender, e);
            }

        }
    }
}
