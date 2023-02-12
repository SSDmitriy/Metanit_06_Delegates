using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metanit_06_Delegates
{
    internal class B06_Covariance
    {

        //01- covariance - delegate of BASE type
        delegate Message Del_MessageBuilder(string text); // type is base type "MESSAGE"

        //02- contravariance
        delegate void EmailReceiver(EmailMessage message);

        //03- generic covarianve
        delegate T Del3_MessageBuilder<out T>(string text);

        //04- generic contravariance
        delegate void Del4_genContra<in T>(T message);

        //05- Co and Contravariance at once
        delegate E Del5_CoAndContra<in M, out E>(M message);

        static void Main(string[] args)
        {
            //01covariance
            EmailMessage WriteEmailMEssage(string text) //here is type of child "EMAILMESSAGE"
            {
                return new EmailMessage(text);
            }

            Del_MessageBuilder del1 = WriteEmailMEssage; //COVARIANCE - when delegate of BASE type returns method of CHILD type

            Console.WriteLine("\n 01 - Covariance");
            Message mes1 = del1("Hello");
            mes1.Print();



            //02contravariance
            Console.WriteLine("\n \n 02 - Contravariance");

            void ReceiveMessage(Message message)
            {
                message.Print();
            }

            EmailReceiver del2 = ReceiveMessage;
            del2(new EmailMessage("Welcome"));



            //03generic covariance
            Console.WriteLine("\n \n 03 - GENERIC Covariance");

            EmailMessage meth3(string text)
            {
                return new EmailMessage(text);
            }

            Del3_MessageBuilder<Message> del3 = meth3; //covariance - for base type MESSAGE assign child meth3 (type EmailMessage)
            Message mes3 = del3("Hello Generic covariance"); // call delegate
            mes3.Print();



            //04generic contravariance
            Console.WriteLine("\n \n 04 - GENERIC CONTRAvariance");
            
            void meth4(Message mes)
            {
                mes.Print();
            }

            Del4_genContra<Message> del4 = meth4;
            Del4_genContra<EmailMessage> del4_1 = del4; //contravaariance- <Message> take child type <EmailMessage>

            del4(new Message("Hello <Message>"));
            del4(new EmailMessage("Hello <EmailMessage>"));


            //05 Co&Contravariance at once
            Console.WriteLine("\n \n 05 - Co&Contravariance at same time");

            EmailMessage meth5(Message mes) //meth5 - "toEmailConverter"
            {
                return new EmailMessage(mes.Text);
            }

            Del5_CoAndContra<SmsMessage, Message> del5 = meth5;
            Message mes5 = del5(new SmsMessage("Hello converter"));
            mes5.Print();


        }


        // three classes - BASE and children
        class Message // base class
        {
            public string Text { get; }
            public Message(string text)
            {
                Text = text;
            }
            public virtual void Print() // virtual - for overriding in child
            {
                Console.WriteLine($"This is BASE metod with message: {Text}");
            }
        }

        class EmailMessage : Message
        {
            public EmailMessage(string text): base(text) { }
            public override void Print()
            {
                Console.WriteLine($"This is EMAIL-class metod with message: {Text}");
            }
        }

        class SmsMessage : Message
        {
            public SmsMessage(string text) : base(text) { }
            public override void Print()
            {
                Console.WriteLine($"This is SMS-class metod with message: {Text}");
            }
        }

       
    }
}
