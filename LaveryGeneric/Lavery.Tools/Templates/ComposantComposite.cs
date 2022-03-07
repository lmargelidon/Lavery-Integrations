using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavery.Tools
{
    public abstract class ComposantComposite : Object
    {
        String sName;
        Type oType;
        String sExtendedTypeType;
        public ComposantComposite(String sName, String sExtendedTypeType)
        {
            this.sName = sName;
            this.sExtendedTypeType = sExtendedTypeType;
        }
        public Type OType { get => oType; set => oType = value; }

        public string SName { get => sName; }
        public string SExtendedTypeType { get => sExtendedTypeType;}

        public virtual ComposantComposite find(String sName, Type oType = default(Type)) { return default(ComposantComposite); }

        public virtual ComposantComposite find(String sName, String sNameParent, Type oType = default(Type)) { return default(ComposantComposite); }

        public Boolean isMe(String sName, Type oType = default(Type))
        {
            return this.sName.Equals(sName) && oType == default(Type) ? true : oType == this.GetType();
        }

    }
    public class Composite : ComposantComposite
    {
        List<ComposantComposite> lComposants = new List<ComposantComposite>();

        public Composite(String sName, String sExtendedTypeType = default(String)) : base(sName, sExtendedTypeType)
        {

        }

        public List<ComposantComposite> LComposants { get => lComposants; }

        public void add(ComposantComposite oBase)
        {
            LComposants.Add(oBase);
        }
        public override ComposantComposite find(String sName, Type oType = default(Type))
        {
            ComposantComposite oRet = default(ComposantComposite);
            foreach (ComposantComposite oCompos in lComposants)           
                if (isMe(sName, oType))
                {
                    oRet = oCompos;
                    break;
                }

            return oRet;
        }
        public override ComposantComposite find(String sName, String sParentName, Type oType = default(Type))
        {
            ComposantComposite oRet = default(ComposantComposite);
            foreach (ComposantComposite oCompos in lComposants)
                if (oCompos.isMe(sParentName, typeof(Composite)))
                {
                    foreach (ComposantComposite oComposChild in ((Composite)oCompos).LComposants)
                        if (oComposChild.isMe(sName, oType))
                        {
                            oRet = oComposChild;
                            break;
                        }                    
                }

            return oRet;
        }

    }
    public class Composant : ComposantComposite
    {

        public Composant(String sName, String sExtendedTypeType = default(String)) : base(sName, sExtendedTypeType)
        {

        }
        

    }

}
