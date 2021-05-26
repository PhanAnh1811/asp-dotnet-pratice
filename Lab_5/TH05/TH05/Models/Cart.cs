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
        public IEnumerable<CartItem> ListItems
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
            {
                if (listItems.Find(s => s._product.Quantity > _new_quantity) != null) //nếu số lượng mua nhỏ hơn số lượng tồn
                    item._quantity = _new_quantity; //thì chấp nhận số lượng mua
                else item._quantity = 1; //ngược lại, thì số lượng mua trả về 1
            }
                
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