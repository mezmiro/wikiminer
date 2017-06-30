using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Wiki_Miner
{
    class PageParser
    {
        private PageContent Page;
        HtmlDocument HTML;
        public PageParser(PageContent Page)
        {
            this.Page = Page;
            HTML = new HtmlDocument();
            FillHTMLObject();
        }
        void FillHTMLObject()
        {
            HTML.LoadHtml(Page.Source);
        }

        bool CheckIfTagInSource() { return true; }
        List<string> CheckIfTagsInSource(List<string> Tags)
        {
            List<string> TagsFound = new List<string>();
            Tags.Sort();

            //This will need a non-linear search algorithm later.
            for (int i = 0; i < Tags.Count(); i++)
            {
                if (Page.Source.Contains(Tags[i]))
                {
                    TagsFound.Add(Tags[i]);
                }
            }
            return TagsFound;
        }
        protected void SetWordCount()
        {

        }
        protected void AddLinks()
        {

        }

        protected void AddImage()
        {

        }
        protected void AddURL()
        {

        }

    }
}
