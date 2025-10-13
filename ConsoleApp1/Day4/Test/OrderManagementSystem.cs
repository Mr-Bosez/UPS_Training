using System;
using System.Collections.Generic;
using System.Text;

public enum DeliveryType
{
    Expedited,
    Standard,
    Express
}

public enum PaymentMethod
{
    CreditCard,
    PayPal,
    BankTransfer
}

public enum CustomerType
{
    VIP,
    Regular,
    New
}

public enum OrderPriority
{
    High,
    Medium,
    Low
}

namespace ConsoleApp1.Day4.Test
{
    internal class OrderManagementSystem
    {
        int loyaltyPoints = 0; // Changed from static readonly to instance field

        public void PlaceOrder()
        {
            Console.WriteLine("Welcome to the Order Management System");
            Console.Write("Enter the total order amount: ");  
            decimal orderAmount = Convert.ToDecimal(Console.ReadLine());    //receive total amount from user
            decimal finalAmount = orderAmount;

            Console.Write("Enter the valid discount code if any else press enter : ");  
            string? discountCode = Console.ReadLine();                      // receive discount code from user
            
            Console.Write("Enter customer type (VIP, Regular, New): ");
            string? inputType = Console.ReadLine();                         // Get Customer Type

            if (!Enum.TryParse(inputType, true, out CustomerType customerType)) // converts userInput to enum
            {
                Console.WriteLine("Invalid customer type entered. Defaulting to 'New'.");
                customerType = CustomerType.New;
            }

            finalAmount = OrderHelper.ApplyMultipleDiscounts(orderAmount, customerType,discountCode ?? string.Empty);
            Console.WriteLine(finalAmount);

            Console.Write("Enter Your location: ");
            string ?location = Console.ReadLine();
            finalAmount = OrderHelper.CalculateTax(location ?? string.Empty, finalAmount);
            finalAmount = OrderHelper.ShippingCharges(finalAmount);
            Console.Write("Enter the country for international shipping: ");
            string? country = Console.ReadLine();
            finalAmount = OrderHelper.InternationalShipping(country ?? string.Empty, finalAmount);
            Console.WriteLine(OrderHelper.FreeGift(finalAmount) ? "Congrats you are eligible for free gift" : "Sorry you are not eligible for free gift");
            loyaltyPoints = OrderHelper.LoyaltyPoints(finalAmount, loyaltyPoints);

            Console.WriteLine("  ---------------------------------------------------");
            Console.WriteLine($"|    Final amount to be paid: ${finalAmount}        |");
            Console.WriteLine("  ---------------------------------------------------");

            OrderPriority orderPriority = OrderHelper.GetOrderPriority(finalAmount);
            Console.WriteLine("The order priority is " + orderPriority);
            Console.Write("Enter the delivery type (expedited ,standard ,express) : ");
            String ? deliveryType= Console.ReadLine();
            if (!Enum.TryParse(deliveryType, true, out DeliveryType selectedDelivery))
            {
                Console.WriteLine("Invalid delivery type entered. Defaulting to 'Standard'.");
                selectedDelivery = DeliveryType.Standard;
            }
            OrderHelper.EstimatedDeliveryTime(selectedDelivery);
            Console.Write("Enter the payment method (CreditCard,Bank Trasfer,Paypal) : ");
            String ? paymentMethod = Console.ReadLine();
            if (!Enum.TryParse(paymentMethod, true, out PaymentMethod selectedPaymentMethod)) 
            {
                Console.WriteLine("Invalid Payment method type entered. Defaulting to 'Bank Transfer'.");
                selectedPaymentMethod = PaymentMethod.BankTransfer;
            }
            OrderHelper.PrintOrderStatus(selectedPaymentMethod);

        }
    }

    public static class OrderHelper
    {
        // Method to calculate discount based on order amount
        public static decimal DiscountAmount(decimal orderAmount)
        {
            decimal finalAmount;
            if (orderAmount > 1000)
            {
                finalAmount = orderAmount - (orderAmount * 0.10m); // Use 0.10m instead of 0.1
                Console.WriteLine("You are applicable for 10% discount");
                return finalAmount;
            }
            else if (orderAmount > 500)
            {
                finalAmount = orderAmount - (orderAmount * 0.05m); // Use 0.05m instead of 5 / 100
                Console.WriteLine("You are applicable for 5% discount");
                return finalAmount;
            }
            else
            {
                Console.WriteLine("You are not applicable for discount");
                finalAmount = orderAmount;
                return finalAmount;
            }
        }

        //Check Discount Eligibility Based on Customer Type

        public static decimal CustomerTypeDis(CustomerType customerType, decimal finalAmount)
        {
            decimal discount = customerType switch
            {
                CustomerType.VIP => 0.15m,
                CustomerType.Regular => 0.05m,
                CustomerType.New => 0.0m,
                _ => 0.0m
            };
            if (discount > 0) Console.WriteLine($"{customerType} customers get a {discount * 100}% discount.");
            finalAmount = finalAmount - (finalAmount * discount);
            return finalAmount;
        }

        // check valid discount code
        public static decimal ValidDiscountCode(string? discountCode, decimal finalAmount)
        {
            if (string.IsNullOrWhiteSpace(discountCode))
                return finalAmount;

            switch (discountCode.Trim().ToUpper())
            {
                case "SAVE10":
                    Console.WriteLine("Discount code applied: SAVE10 (10% off)");
                    return finalAmount - (finalAmount * 0.10m);

                case "SAVE20":
                    Console.WriteLine("Discount code applied: SAVE20 (20% off)");
                    return finalAmount - (finalAmount * 0.20m);

                default:
                    Console.WriteLine("Invalid discount code entered.");
                    return finalAmount;
            }
        }

        //multiple discounts
        public static decimal ApplyMultipleDiscounts(decimal orderAmount, CustomerType customerType, string discountCode)
        {
            decimal finalAmount = DiscountAmount(orderAmount);
            finalAmount = ValidDiscountCode(discountCode, finalAmount);
            finalAmount = CustomerTypeDis(customerType, finalAmount);
            return finalAmount;
        }

        //tax calculation based on location
        public static decimal CalculateTax(string location, decimal finalAmount)
        {
            decimal taxRate = location.ToLower() switch
            {
                "california" => 0.08m,
                "texas" => 0.0625m,
                "florida" => 0.07m,
                _ => 0m
            };
            if (taxRate > 0) Console.WriteLine($"A tax rate of {taxRate * 100}% has been applied for {location}.");
            return finalAmount + (finalAmount * taxRate);
        }


        // Determine Shipping charges based on total amount
        public static decimal ShippingCharges(decimal finalAmount)
        {   int shippingCharge;
            if (finalAmount > 500)
            {
                shippingCharge = 0;
                Console.WriteLine("You are applicable for free shipping");
                return finalAmount + shippingCharge;
            }
            else
            {
                shippingCharge = 50;
                Console.WriteLine("You are not applicable for free shipping and  $50  applied for shipping ");
                return finalAmount + shippingCharge; ;
            }
        }

        //international shipping charges
        public static decimal InternationalShipping(String country,decimal finalAmount)
        {
            if (finalAmount < 500)
            {
                decimal shippingCost = country.ToLower() switch
                {
                    "canada" or "usa" or "mexico" => 20.0m,
                    "europe" => 30.0m,
                    _ => 50.0m
                };
                Console.WriteLine($"Shipping cost to {country} is ${shippingCost}");
                return finalAmount + shippingCost;
            }
            return finalAmount;
        }

        // free gifts based on order amount
        public static bool FreeGift(decimal finalAmount)
        {
            return finalAmount > 500;

        }

        //customer loyalty points
        public static int LoyaltyPoints(decimal finalAmount, int loyaltyPoints)
        {
            if (finalAmount > 1000)
            {
                loyaltyPoints += 100;
                Console.WriteLine("You have earned 100 loyalty points");
                return loyaltyPoints;
            }
            else if (finalAmount > 500)
            {
                loyaltyPoints += 50;
                Console.WriteLine("You have earned 50 loyalty points");
                return loyaltyPoints;
            }
            else
            {
                loyaltyPoints += 10;
                Console.WriteLine("You have earned 10 loyalty points");
                return loyaltyPoints;
            }
        }


        //Order Priority Based on Order Amount
        public static OrderPriority GetOrderPriority(decimal finalAmount)
        {
            OrderPriority orderPriority = finalAmount switch
            {
                > 1000 => OrderPriority.High,
                > 500 => OrderPriority.Medium,
                _ => OrderPriority.Low
            };
            return orderPriority;
        }


        // determine Estimated delivery time based on delivery type
        public static void EstimatedDeliveryTime(DeliveryType deliveryType)
        {
            switch (deliveryType)
            {
                case DeliveryType.Express:
                    Console.WriteLine("Estimated delivery time: 1 days");
                    break;
                case DeliveryType.Expedited:
                    Console.WriteLine("Estimated delivery time: 2 days");
                    break;
                case DeliveryType.Standard:
                    Console.WriteLine("Estimated delivery time: 5-7 days");
                    break;
                default:
                    Console.WriteLine("Invalid order priority");
                    break;
            }
        }

        //order status based on payment method
        public static void PrintOrderStatus(PaymentMethod paymentMethod)
        {
            string status = paymentMethod switch
            {
                PaymentMethod.CreditCard => "Order Approved",
                PaymentMethod.PayPal => "Order Pending",
                PaymentMethod.BankTransfer => "Order Processing",
                _ => "Unknown Status"
            };

            Console.WriteLine(status);
        }
    } 
}
