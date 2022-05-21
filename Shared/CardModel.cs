using System;
namespace Velocity.Shared
{
    public class CardModel{
        public string bgType {get; set;}
        public string origin { get; set; }
        public string content {get; set;}
        public int index {get; set;}
        public string hidden {get; set;}

        public void SetVals(string bg, string ori, string cont, int ind, string hidde = ""){
            bgType = bg;
            origin = ori;
            content = cont;
            index = ind;
            hidden = hidde;
        }
    }
}