using System;
using DevExpress.Xpo;

namespace DXApplication1
{

    public class CbbItem //: XPObject
    {
        private Object _Key;
        private Object _Value;

       

        public CbbItem(Object Key, Object Value)
        {
            this.Key = Key;
            this.Value = Value;
        }

        public object Key { get => _Key; set => _Key = value; }
        public object Value { get => _Value; set => _Value = value; }

        public override string ToString()
        {
            return this.Value + "";
        }
        //public CbbItem() : base()
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}

        //public CbbItem(Session session) : base(session)
        //{
        //    // This constructor is used when an object is loaded from a persistent storage.
        //    // Do not place any code here.
        //}



        //public override void AfterConstruction()
        //{
        //    base.AfterConstruction();
        //    // Place here your initialization code.
        //}
    }

}