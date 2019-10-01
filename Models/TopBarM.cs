using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtLancer.Models
{
    class TopBarM
    {
        public string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    //RaisePropertyChanged("Title");
                }
            }
        }
    }
}
