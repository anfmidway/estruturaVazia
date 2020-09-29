using CSN.MESCDPT.Service;
using CSN.MESCDPTC.Domain.Entities;
using CSN.MESCDPTC.Domain.Interfaces.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSN.MESCDPTC.Web
{
    public partial class _Default : Page
    {
        private   IServiceProduct _service;

        
         
        protected void Page_Load(object sender, EventArgs e)
        {
            _service = new ServiceProduct();


           IEnumerable<Product> products =  _service.ListProduct();
            gdvProdutos.DataSource = products;
            gdvProdutos.DataBind();
        }
    }
}