using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdBack.ViewModels;

namespace ProdBack.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult ProductList()
        {
            var products = new List<ProductVM>
            {
                new ProductVM{
                    Id =1,
                    Name ="Free",
                    Image ="https://cdn4.wpbeginner.com/wp-content/uploads/2019/01/whyiswpfree.png",
                    Price="$0",
                    Description = new string[] {
                        "10 users included","2 GB of storage","Email support","Help center access"
                    },
                    BtnContent="Sign up for free"
                },
                new ProductVM{
                    Id =2,
                    Name ="Pro",
                    Image ="https://iccrc-crcic.ca/wp-content/uploads/2018/01/Become-a-Immigration-Professional-1468x848.jpg",
                    Price="$15",
                    Description = new string[] {
                        "20 users included","10 GB of storage","Priority email support","Help center access"
                    },
                    BtnContent="Get started"
                },
                new ProductVM{
                    Id =3,
                    Name ="Enterprise",
                    Image ="https://vignette.wikia.nocookie.net/memoryalpha/images/d/df/USS_Enterprise-A_quarter.jpg/revision/latest?cb=20100518022537&path-prefix=en",
                    Price="$29",
                    Description = new string[] {
                        "30 users included","15 GB of storage","Phone and email support","Help center access"
                    },
                    BtnContent="Contact us"
                }
            };
            return Ok(products);
        }
    }
}