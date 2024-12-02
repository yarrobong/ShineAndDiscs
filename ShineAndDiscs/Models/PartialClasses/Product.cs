﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShineAndDiscs.Models
{
    public partial class Product
    {
        public string ImagePath
        {
            get
            {
                if (Image == null)
                {
                    return "..Assets\\Images\\Resources\\picture.png";
                }
                else
                {
                    return "../Resources" + Image;
                }
            }
        }
        public string MaterialList
        {
            get
            {
                string materials= "Материалы: ";
                List<string> arrayMaterials = new List<string> { };
                List<ProductMaterial> arrayActiveProduct = ProductMaterial.Where(x=>x.ProductID==ID).ToList();
                foreach (var item in arrayActiveProduct)
                {
                    arrayMaterials.Add(item.Material.Title.ToString());
                }
                materials = string.Join(",", arrayMaterials);
                return materials;
            }
        }

        public double CostProduct
        {
            get
            {
                double costProduct = 0;
                List<ProductMaterial> arrayActiveProduct = ProductMaterial.Where(x => x.ProductID==ID).ToList();
                foreach (var item in arrayActiveProduct)
                {
                    costProduct += Convert.ToDouble(item.Count) * Convert.ToDouble(item.Material.Cost);
                }
                return costProduct;
            }
        }
    }
}
