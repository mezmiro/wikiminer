using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki_Miner
{
    class PageContent
    {
        string PageSource;
        List<string> Links;
        List<string> Tags;
        List<Image> Images;

        string URI;
        int WordCount;

        public string Source
        {
            get
            {
                return PageSource;
            }
            set
            {
                PageSource = value;
            }
        }
    }

    class Image
    {
        string SourceURI;
        string Filename;
        string Extension;
        int Width;
        int Height;

        //Not sure how to do this yet really..
        byte[] File;


    }
}
