using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class Actions
    {
        private static Actions instance;
        private Actions()
        {
            actionList = new List<string>();
        }
        public static  Actions GetInstance()
        {
            if(instance == null)
            {
                instance = new Actions();
                
            }
            return instance;
        }
        public List<string> actionList { get; set; }
        public string lastAction
        {
            get { if(instance == null) return "nothing...";
                return actionList[actionList.Count - 1];
            }
        }

    }
}