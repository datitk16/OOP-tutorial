
// lớp mà từ đó gửi đi sự kiện gọi là publisher và các lớp nhận được sự kiện gọi là subscriber

// ví dụ dưới đây dùng delegate (đã biết ở phần trước ) để xây dựng cơ chế để một lớp này đăng ký sự kiện từ một lớp khác
using System;
namespace Event
{
    public class Event_07
    {
        // Publisher là lớp phát đi sự kiện, bằng cách gọi
        // một delegate trong phước send
        public class Publisher
        {
            public delegate void NotifyNews(object data);

            public NotifyNews event_news;

            public void Send()
            {
                event_news?.Invoke("Có tin mới");
            }
        }

        //SubscriberA  lớp này đăng ký nhận sự kiện từ Publisher
        // bằng phương thức Sub, khi sự kiện xảy ra nó sẽ gọi ReceiverFromPublisher

        public class SubscriberA
        {
            public void Sub(Publisher p)
            {
                p.event_news += ReceiverFromPublisher;
            }

            void ReceiverFromPublisher(object data)
            {
                Console.WriteLine("SubscriberA", data.ToString());
            }
        }

        // SubscriberA lớp này đăng ký nhận sự kiện từ Publisher
        // Bằng các phương thứ Sub - khi đăng ký nó hủy việc nhận sự kiện của các đối tượng khác
        // Khi sự kiện xảy ra nó sẽ gọi ReceiverFromPublisher


        public class SubscriberB
        {
            public void Sub(Publisher publisher)
            {
                publisher.event_news = null; // hủy các đối tượng khác nhận sự kiện 
                publisher.event_news += ReceiverFromPublisher;
            }

            void ReceiverFromPublisher(object data)
            {
                Console.WriteLine("SubscriberB: " + data.ToString());
            }
        }


        public static void TestDelegate()
        {
            Publisher p = new Publisher();
            SubscriberA sa = new SubscriberA();
            SubscriberB sb = new SubscriberB();

            sa.Sub(p);
            sb.Sub(p);

            p.Send();
        }

    }
}