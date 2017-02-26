using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApplication2
{
    public static class Class2
    {
        static int _Linex;

        public static int LineX
        {
            get
            {
                return _Linex;
            }
            set
            {
                _Linex = value;
            }
        }

        static int _Liney;

        public static int LineY
        {
            get
            {
                return _Liney;
            }
            set
            {
                _Liney = value;
            }
        }




        static int _TopLinex;

        public static int TopLineX
        {
            get
            {
                return _TopLinex;
            }
            set
            {
                _TopLinex = value;
            }
        }

        static int _TopLiney;

        public static int TopLineY
        {
            get
            {
                return _TopLiney;
            }
            set
            {
                _TopLiney = value;
            }
        }


        static int _BottomLinex;

        public static int BottomLineX
        {
            get
            {
                return _BottomLinex;
            }
            set
            {
                _BottomLinex = value;
            }
        }

        static int _BottomLiney;

        public static int BottomLineY
        {
            get
            {
                return _BottomLiney;
            }
            set
            {
                _BottomLiney = value;
            }
        }



        public static  ArrayList MyGlobalList = new ArrayList();

    }
}
