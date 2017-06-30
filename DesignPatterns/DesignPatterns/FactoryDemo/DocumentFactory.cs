using System.Collections.Generic;

namespace DesignPatterns
{
    public abstract class DocumentFactory
    {
        private  List<Page> _pages = new List<Page>();

        public DocumentFactory()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }
        public abstract void CreatePages();

    }
}