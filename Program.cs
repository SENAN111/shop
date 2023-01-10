namespace bookshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
           app.MapControllerRoute(name: "areas",pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(name: "Contact", pattern: "Contact", defaults: new { Controller = "Home", Action = "Contact" });
            app.MapControllerRoute(name: "Product_detail", pattern: "Product_detail", defaults: new { Controller = "Home", Action = "Product_detail" });
            app.MapControllerRoute(name: "product_listing", pattern: "product_listing", defaults: new { Controller = "Home", Action = "product_listing" });
            app.MapControllerRoute(name: "shop_cart", pattern: "shop_cart", defaults: new { Controller = "Home", Action = "shop_cart" });
            app.Run();

        }
    }
}