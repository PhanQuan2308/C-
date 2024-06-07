using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Slot8
{
    public abstract class GeometricObject
    {
        protected string color;
        protected double weight;
        protected GeometricObject(){
            color = "white";
            weight = 1.0;
        }
        protected GeometricObject(string color, double weight){
            this.color = color;
            this.weight = weight;
        }
        public string PColor{
            get{
                return color;
            }
            set{
                color = value;
            }
        }
        public double PWeight{
            get{
                return weight;
            }
            set{
                weight = value;
            }
        }
        public abstract double findArea();
        public abstract double findPerimeter();
    }
}