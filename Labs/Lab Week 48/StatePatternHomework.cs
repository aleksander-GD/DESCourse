using System;

namespace DesignPatternExercise {


    class App {


         public static void Main(string[] args)
        {


        }
    }


    interface OrderState {
        void handle();
    }


    public class Pending : OrderState
    {
        public void handle() {

        }
    }
    public class Created : OrderState{
        public void handle() {

        }
    }

    public class Shipped : OrderState {
        public void handle() {

        }
    }   

    public class Cancelled : OrderState {
        public void handle() {
            
        }
    }








    class DeliverySystem {
        

        string[] states = new string[]{"created", "pending", "shipped", "cancelled"};

        public void handleOrder(Order order) {
            if(order.GetState().Equals(states[0])) {
                Console.WriteLine("Order is created");
            } else if(order.GetState().Equals(states[1])) {
                Console.WriteLine("Order is pending");
            } else if(order.GetState().Equals(states[2])) {
                Console.WriteLine("Order is shipped");
            } else {
                Console.WriteLine("Order is cancelled");
            }
        }




    }

    class Order {
        string state = "";
        string product;
        double price;
        public Order(string product, double price) {
            this.product = product;
            this.price = price;
            this.state = "created";
        }

        public void SetState(string newState) {
            this.state = newState;
        }

        public string GetState() {
            return this.state;
        }
    }


}