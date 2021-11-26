using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HansenApi.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperAttribute : Attribute
    {
        // Private fields
        private string name;
        private string role;
        private bool reviewed;

        // This constructor defines two required parameters: name and role
        public DeveloperAttribute(string name, string role)
        {
            this.name = name;
            this.role = role;
            this.reviewed = false;
        }

        // Define Name Property
        // This is a read-only attribute.
        public virtual string Name
        {
            get { return name; }
        }

        // Define Role property.
        // This is a read-only attribute.
        public virtual string Role
        {
            get { return role; }
        }

        // Define reviewed property.
        // this is a read/write attribute
        public virtual bool Reviewed
        {
            get { return reviewed; }
            set { reviewed = value; }
        }
    }
}
