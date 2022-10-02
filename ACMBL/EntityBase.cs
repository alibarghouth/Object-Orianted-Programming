using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMBL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public  bool IsNew { get;  private set; }
        public  bool Haschange { get; set; }
        public bool IsValid => Validatin();
        public abstract  bool Validatin();
        

    }
}
