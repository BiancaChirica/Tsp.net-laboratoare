using System;


namespace laborator1
{

    public delegate string MyDel(string str);

    public class EventProgram
    {
        public event MyDel MyEvent;

        public EventProgram()
        {
            this.MyEvent += new MyDel(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        public string SetEvent(string username)
        {
            string result = MyEvent(username);
            return result;
        }

    }
    }
