using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Text;
namespace Library
{

public class CensoEdad : Visitor
{
    public int edad =0;
    public override void Visit(Node s)
    {
        //this.ContentBuilder.Clear();
         this.edad += s.Own.Edad;

        foreach (Node item in s.Children)
        {
            item.Accept(this);
        }
        

        this.ContentBuilder.Append($"{edad}\n");
    }


    }
}
