using System.Web.Mvc;
using System.Web.Routing;
using Kendo.Mvc.Extensions;
using BL.Facade;
using BL.DTO;

namespace KendoUIApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerFacade customerFacade;

        public CustomerController(ICustomerFacade customerFacade)
        {
            this.customerFacade = customerFacade;
        }

        public ActionResult Index()
        {
            return View(customerFacade.GetCustomers());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Customers_Create(CustomerDTO customer)
        {
            if (ModelState.IsValid)
            {
                customerFacade.CreateCustomer(customer);

                RouteValueDictionary routeValues = this.GridRouteValues();
                return RedirectToAction("Index", routeValues);
            }

            return View("Index", customerFacade.GetCustomers());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Customers_Update(CustomerDTO customer)
        {
            if (ModelState.IsValid)
            {
                customerFacade.UpdateCustomer(customer);

                RouteValueDictionary routeValues = this.GridRouteValues();
                return RedirectToAction("Index", routeValues);
            }

            return View("Index", customerFacade.GetCustomers());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Customers_Destroy(CustomerDTO customer)
        {
            RouteValueDictionary routeValues;

            customerFacade.DeleteCustomer(customer.Id);

            routeValues = this.GridRouteValues();

            return RedirectToAction("Index", routeValues);
        }
    }
}
