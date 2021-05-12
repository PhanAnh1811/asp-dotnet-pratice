using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TH05.Models;

namespace TH05.Models
{
    //Tạo lớp CartItem chứa các dòng sảm phẩm trong giỏ hàng 
    public class CartItem
    {
        public Product _product { get; set; }
        public int _quantity { get; set; }
    }
    public class Cart
    {
        [Key]
        public string idTemp { get; set; }

        List<CartItem> listItems = new List<CartItem>();
        public IEnumerable<CartItem> Listtems
        {
            get { return listItems; }
        }
        public void Add_Product_Cart(Product product, int quantity = 1)
        {
            var item = listItems.FirstOrDefault(s => s._product.ProductID == product.ProductID);
            if (item == null)
            {
                listItems.Add(new CartItem
                {
                    _product = product,
                    _quantity = quantity,
                });
            }
            else
                item._quantity += quantity; //tổng số lượng giỏ hàng được cộng dồn
        }

        public int Total_quantity()
        {
            return listItems.Sum(s => s._quantity);
        }

        public decimal Total_money()
        {
            var total = listItems.Sum(s => s._quantity * s._product.Price);
            return (decimal)total;
        }

        public void Update_quantity(int id,int _new_quantity)
        {
            var item = listItems.Find(s => s._product.ProductID == id);
            if (item != null)
                item._quantity = _new_quantity;
        }

        public void Remove_CartItem(int id)
        {
            listItems.RemoveAll(s => s._product.ProductID == id); 
        }
        public void ClearCart()
        {
            listItems.Clear();
        }
    }
}