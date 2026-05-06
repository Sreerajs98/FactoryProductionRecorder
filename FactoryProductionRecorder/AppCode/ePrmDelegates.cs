using System;
using System.Collections.Generic;
using System.Text;

namespace ePrmProdDelegates
{

    public delegate void ePrmProdCustomHandler(object sender, ePrmProdCustomEventArg e);

    public class ePrmProdCustomEventArg : EventArgs
    {
        //
        private string[] srchId;
        public string[] SelectedStrings
        {
            get
            {
                return srchId;
            }
            set
            {
                srchId = value;
            }
        }


        private string[] srchAccessAngleStrings;
        public string[] AccSelectedStrings
        {
            get
            {
                return srchAccessAngleStrings;
            }
            set
            {
                srchAccessAngleStrings = value;
            }
        }


        private string[] srchAccessTrimStrings;
        public string[] AccSelectedStringsTrims
        {
            get
            {
                return srchAccessTrimStrings;
            }
            set
            {
                srchAccessTrimStrings = value;
            }
        }

        //
        private int srchno;
        public int SelectedInt
        {
            get
            {
                return srchno;
            }
            set
            {
                srchno = value;
            }
        }


        //
        private string srchstr;
        public string SelectedString
        {
            get
            {
                return srchstr;
            }
            set
            {
                srchstr = value;
            }
        }

        //
        private string statusstr;
        public string StatusString
        {
            get
            {
                return statusstr;
            }
            set
            {
                statusstr = value;
            }
        }

        //
        private double srchdbl = 0;
        public double SelectedDouble
        {
            get
            {
                return srchdbl;
            }
            set
            {
                srchdbl = value;
            }
        }

    }
}
