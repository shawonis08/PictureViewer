using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picture_Viewer
{
    public class Item
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public FieldTypeEnum Type { get; set; }
        public Position TopLeft { get; set; }
        public Position BottomRight { get; set; }
    }

    public class Position
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public enum FieldTypeEnum
    {
        Charecter = 0,
        Numeric,
        Image,
        Barcode

    }
}
