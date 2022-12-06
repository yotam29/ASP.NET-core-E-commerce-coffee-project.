using Microsoft.EntityFrameworkCore;
namespace CIDM_3312_FINAL_PROJECT_YOTAM.Models
{
    public static class SeedData
    {
        public static void Initialize (IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
                {
                    // look for any professor
                    if( context.items.Any())
                    {
                        return;
                    }

                    context.items.AddRange
                    (
                        new item
                        {
                            item_name = "Breville Barista Express Espresso Machine",
                            item_price= 599,
                            item_description="The Breville Barista Express delivers third wave specialty coffee at home using the 4 keys formula and is part of the Barista Series that offers all in one espresso machines with integrated grinder to go from beans to espresso in under one minute"
                        },
                        new item
                        {
                            item_name = "Breville Barista Touch Espresso Machine",
                            item_price= 879,
                            item_description="The Breville Barista Touch Espresso Machine helps you create third wave specialty coffee with ease with intuitive touch screen display with pre-programmed cafe drinks in 3 easy steps Grind Brew and Milk; You can easily adjust the coffee strength, milk texture and temperature to suit your taste."
                        }
                        ,
                        new item
                        {
                            item_name = "Breville Barista Touch Espresso Machine Model 2",
                            item_price= 979,
                            item_description="The Breville Barista Touch Espresso Machine helps you create third wave specialty coffee with ease with intuitive touch screen display with pre-programmed cafe drinks in 3 easy steps Grind Brew and Milk; You can easily adjust the coffee strength, milk texture and temperature to suit your taste."
                        }
                        ,
                        new item
                        {
                            item_name = "Breville Barista Touch Espresso Machine Model 3",
                            item_price= 1079,
                            item_description="The Breville Barista Touch Espresso Machine helps you create third wave specialty coffee with ease with intuitive touch screen display with pre-programmed cafe drinks in 3 easy steps Grind Brew and Milk; You can easily adjust the coffee strength, milk texture and temperature to suit your taste."
                        }
                        ,
                        new item
                        {
                            item_name = "Breville Barista Touch Espresso Machine model 4",
                            item_price= 1179,
                            item_description="The Breville Barista Touch Espresso Machine helps you create third wave specialty coffee with ease with intuitive touch screen display with pre-programmed cafe drinks in 3 easy steps Grind Brew and Milk; You can easily adjust the coffee strength, milk texture and temperature to suit your taste."
                        }
                        ,
                        new item
                        {
                            item_name = "PHILIPS 3200 Series Fully Automatic Espresso Machine",
                            item_price= 799,
                            item_description="Enjoy 5 coffees, Intuitive touch display 12-step grinder adjustment"
                        }
                        ,
                        new item
                        {
                            item_name = "PHILIPS 3200 Series Fully Automatic Espresso Machine Model 2",
                            item_price= 899,
                            item_description="Enjoy 5 coffees, Intuitive touch display 12-step grinder adjustment"
                        },
                        new item
                        {
                            item_name = "PHILIPS 3200 Series Fully Automatic Espresso Machine Model 3",
                            item_price= 999,
                            item_description="Enjoy 5 coffees, Intuitive touch display 12-step grinder adjustment"
                        }
                        ,
                        new item
                        {
                            item_name = "PHILIPS 3200 Series Fully Automatic Espresso Machine Model 3",
                            item_price= 1099,
                            item_description="Enjoy 5 coffees, Intuitive touch display 12-step grinder adjustment"
                        }
                        ,
                        new item
                        {
                            item_name = "PHILIPS 3200 Series Fully Automatic Espresso Machine Model 4",
                            item_price= 1199,
                            item_description="Enjoy 5 coffees, Intuitive touch display 12-step grinder adjustment"
                        }
                        ,
                        new item
                        {
                            item_name = "Geek Chef Espresso Machines,Espresso Maker for home",
                            item_price= 139,
                            item_description="This electric espresso maker has single shot and double shot, and the extraction will stop automatically when the right coffee strength is reached. And it has a strict temperature control system to make your coffee taste perfect."
                        }
                        ,
                        new item
                        {
                            item_name = "Geek Chef Espresso Machines,Espresso Maker for home Model 2",
                            item_price= 239,
                            item_description="This electric espresso maker has single shot and double shot, and the extraction will stop automatically when the right coffee strength is reached. And it has a strict temperature control system to make your coffee taste perfect."
                        }
                        ,
                        new item
                        {
                            item_name = "Geek Chef Espresso Machines,Espresso Maker for home Model 3",
                            item_price= 339,
                            item_description="This electric espresso maker has single shot and double shot, and the extraction will stop automatically when the right coffee strength is reached. And it has a strict temperature control system to make your coffee taste perfect."
                        }
                        ,
                        new item
                        {
                            item_name = "Geek Chef Espresso Machines,Espresso Maker for home Model 4",
                            item_price= 439,
                            item_description="This electric espresso maker has single shot and double shot, and the extraction will stop automatically when the right coffee strength is reached. And it has a strict temperature control system to make your coffee taste perfect."
                        }
                        ,
                        new item
                        {
                            item_name = "De'Longhi ECAM37095TI",
                            item_price= 1699,
                            item_description="3.5” TFT full-touch, colorful display provides intuitive and simple experience of one-touch specialty recipes"
                        }
                        ,
                        new item
                        {
                           item_name = "De'Longhi ECAM37095TI Model 2",
                            item_price= 1899,
                            item_description="3.5” TFT full-touch, colorful display provides intuitive and simple experience of one-touch specialty recipes"
                        }
                        ,
                        new item
                        {
                           item_name = "De'Longhi ECAM37095TI Model 3",
                            item_price= 2099,
                            item_description="3.5” TFT full-touch, colorful display provides intuitive and simple experience of one-touch specialty recipes"
                        }
                        ,
                        new item
                        {
                           item_name = "De'Longhi ECAM37095TI Model 4",
                            item_price= 2299,
                            item_description="3.5” TFT full-touch, colorful display provides intuitive and simple experience of one-touch specialty recipes"
                        }
                        ,
                        new item
                        {
                            item_name = "Lavazza Super Crema Standard",
                            item_price= 25,
                            item_description="One 2.2 pounds bag of Lavazza Super Crema Italian whole coffee beans60% Arabica and 40% Robusta"
                        }
                        ,
                        new item
                        {
                           item_name = "Lavazza Super Crema Gold",
                            item_price= 35,
                            item_description="One 2.2 pounds bag of Lavazza Super Crema Italian whole coffee beans60% Arabica and 40% Robusta"
                        }
                        ,
                        new item
                        {
                            item_name = "Lavazza Super Crema Premuim",
                            item_price= 45,
                            item_description="One 2.2 pounds bag of Lavazza Super Crema Italian whole coffee beans60% Arabica and 40% Robusta"
                        }
                        ,
                        new item
                        {
                            item_name = "San Francisco Bay Coffee Standard",
                            item_price= 22,
                            item_description="Our iconic Fog Chaser is a blend of dark and medium roasted beans which results in a enjoyable medium dark roast coffee. It's a great combination of flavor, balance and smoothness that will chase away even the thickest morning fog."
                        }
                        ,
                        new item
                        {
                            item_name = "San Francisco Bay Coffee Gold",
                            item_price= 32,
                            item_description="Our iconic Fog Chaser is a blend of dark and medium roasted beans which results in a enjoyable medium dark roast coffee. It's a great combination of flavor, balance and smoothness that will chase away even the thickest morning fog."
                        }
                        ,
                        new item
                        {
                            item_name = "San Francisco Bay Coffee Premium",
                            item_price= 42,
                            item_description="Our iconic Fog Chaser is a blend of dark and medium roasted beans which results in a enjoyable medium dark roast coffee. It's a great combination of flavor, balance and smoothness that will chase away even the thickest morning fog."
                        }
                        ,
                        new item
                        {
                            item_name = "STARBUCKS Espresso Roast Standard",
                            item_price= 11,
                            item_description="STARBUCKS ESPRESSO ROAST COFFEE—A classic and time-honored dark roast with notes of rich molasses and caramel that is perfect for making classic espresso drinks"
                        }
                        ,
                        new item
                        {
                            item_name = "STARBUCKS Espresso Roast Gold",
                            item_price= 16,
                            item_description="STARBUCKS ESPRESSO ROAST COFFEE—A classic and time-honored dark roast with notes of rich molasses and caramel that is perfect for making classic espresso drinks"
                        }
                        ,
                        new item
                        {
                            item_name = "STARBUCKS Espresso Roast Premium",
                            item_price= 21,
                            item_description="STARBUCKS ESPRESSO ROAST COFFEE—A classic and time-honored dark roast with notes of rich molasses and caramel that is perfect for making classic espresso drinks"
                        }


                    );
                    context.SaveChanges();
                }
        }
    }
}