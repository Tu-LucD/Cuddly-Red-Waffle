using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuddly_Red_Waffle_app.AppClasses
{
    class HealthCategory
    {
        private int healthID;
        private string category;

        public HealthCategory(int healthID, string category)
        {
            HealthID = healthID;
            Category = category;
        }

        public int HealthID { get => healthID; set => healthID = value; }
        public string Category { get => category; set => category = value; }
    }
}
