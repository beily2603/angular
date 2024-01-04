using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DB
    {
        public static List<Feedback> feedbacks = new List<Feedback>()
        {
            //new Feedback(1,"Shira K.",new DateTime(2022,11,3),
            //    "Chaim is a professional, serious and very reliable computer technician! The service experience with him is very pleasant, he finds and explains in detail exactly what the problem is so that the customer understands, and he gives the most optimal option for correcting the problem! The sellers are extremely fair and simply see that it is in the best interest of the customer. In addition, Chaim comes on time to the customer's address to see and take the problematic product and returns it to a witness",4),
            //new Feedback(2,"Yosef",new DateTime(2022,11,1),
            //    "I had a computer malfunction for a long time and several technicians were unable to overcome it until I came back to life. I received fast, professional and reliable service and the problem was solved to my satisfaction and at a fair price.",13),
            //new Feedback(3,"Noa",new DateTime(2022,10,23)
            //    ,"A high level professional. managed to solve a problem for me that many have failed before. Personal, courteous and reliable service. Above all, human!",7),
            //new Feedback(4,"Tomer",new DateTime(2022,9,1)
            //    ,"I received service from now to now. Chaim recognized the problem and found an effective solution that did not require replacing expensive parts. When you work with the computer on a daily basis in the office, an immediate solution is worth every penny - the repair price was also more than decent.",2)
        };
        public static List<Service> services = new List<Service>()
        {
            //new Service(5,"computer repairing","fixes and repairs all kindes of computers: laptops,desktops,servers and more. \n Fixing computer hardware problems\r\nA modern personal computer is built like \"Lego\" - few, fairly large parts that simply connect to each " +
            //    "other and can be removed and replaced very easily.\r\n\r\nPower supply - a fault in" +
            //    " the power supply is characterized by the electrical inability to turn on the computer." +
            //    " There is no problem in replacing a power supply by yourself, see instructions in the article " +
            //    "\"Common computer malfunctions\". Be sure to purchase a power supply that fits in its connections " +
            //    "to the motherboard, so it's worth disassembling and taking it to the store. Sometimes the need to " +
            //    "replace a power supply for a more powerful model arises because of the addition of components to " +
            //    "the computer (disks, drives, cards, etc.).\r\n\r\nFan - in most computers there are at least " +
            //    "two fans, one inside the power supply and the other mounted on the central processor and usually " +
            //    "sold together with it. A malfunctioning fan may cause the temperature of the power supply or the" +
            //    " processor to rise, and these are sensitive to this and will disconnect themselves in such a case." +
            //    " Replacing a fan in the power supply is not acceptable - this unit is sold as a single assembly," +
            //    " and the price of the replacement work comes to the price of a new power supply. Replacing a fan " +
            //    "that \"rides\" on the processor is possible, but must be done carefully, preferably in an " +
            //    "authorized computer lab.\r\n\r\nHard disk - since it is a mechanical component, a hard disk " +
            //    "is prone to malfunctions (see the article \"Common computer malfunctions\"). It is very " +
            //    "worthwhile to get a cure for the blow early, purchase a new disk with a large volume, " +
            //    "install the old disk as a backup disk and keep a copy of the materials that are important " +
            //    "to you on it. This is the best advice you've ever received - guaranteed!\r\n\r\nMotherboard " +
            //    "- this is the central component of the computer, and all the other components are connected to it" +
            //    ". Motherboard failures are quite rare, but they do happen. Replacing a motherboard sometimes also" +
            //    " requires replacing the processor and the memory, so its price may reach very close to the price of" +
            //    " a brand new computer. Therefore, the replacement of a motherboard should be considered very " +
            //    "carefully and in such a situation a computer repair professional should be consulted.\r\n\r\nReplacing" +
            //    " a processor - a central processor of a computer almost never breaks down! A computer that \"works slowly\"" +
            //    " usually does so for completely different reasons - see the article \"Common computer malfunctions\". Replacing" +
            //    " a processor in an existing computer is a very sensitive operation that is not acceptable, because there" +
            //    " must be a careful match between the processor and the motherboard. Therefore, it is advisable to replace" +
            //    " such a processor - if at all - only in a reliable computer laboratory, by a computer technician, and while" +
            //    " checking the cost compared to the purchase of a new computer.",new Range(150,1050),24,"hardware/1.jpg","hardware/2" +
            //    ".jpg","hardware/3.jpg","hardware/5.jpg","hardware/6.jpg","hardware/7.jpg"),
            //new Service(6,"Expanding memory","The function of the computer's memory is " +
            //    "to process the information and allow continuous and proper operation of " +
            //    "all the programs at the same time. If there is not enough memory, the computer" +
            //    " will work slowly and you will not be able to open several heavy programs " +
            //    "at the same time. Is there a limit to the amount of credit that can be added" +
            //    " to the computer?\r\nWhether it is a laptop or a desktop computer, it is not" +
            //    " possible to expand the memory in an unlimited amount, because the number of" +
            //    " inputs on the motherboard is limited.",new Range(50,150),4,"memory/1.jpg",
            //    "memory/2.jpg","memory/3.jpg","memory/4.jpg"),
            //new Service(7,"Software Installation","Installs all software including " +
            //    "operation systems, office packages, Adobe packages, etc. \n Software Installation\r\nUsers who" +
            //    " add new software to their computer must install it according " +
            //    "to the installation instructions attached to it, after verifying " +
            //    "that the computer resources they" +
            //    " have are sufficient to run the new software. Almost always," +
            //    " following the installation instructions carefully results in a " +
            //    "successful installation.\r\n\r\nOperat" +
            //    "ing system installation\r\nThis is an operation that is usually" +
            //    " carried out by computer technicians in the computer lab where that" +
            //    " computer was assembled and prepared for marketing. In any case, " +
            //    "sometimes there is no escape from reinstalling the operating system:" +
            //    " when replacing a new computer, when replacing the motherboard, when" +
            //    " replacing the hard disk with another, when upgrading an old operating" +
            //    " system to a new system, etc. Sometimes, reinstalling the operating" +
            //    " system is the only way to overcome severe computer crashes caused by " +
            //    "malware or hardware failures. Experienced computer owners are able to" +
            //    " install an operating system themselves without special problems. Users " +
            //    "who are not found in the computer taps\r\nor are not confident enough in" +
            //    " themselves, they would do well to leave this task in the hands of someone" +
            //    " who knows how to carry it out.",new Range(40,560),5,"software/1.jpg","software/2.jpg","software/3.jpg","software/4.jpg"),
            //new Service(8,"Antivirus updates","updates and installs antivirus " +
            //    "from all companys for all needs,There is nothing more annoying" +
            //    " than finding out that you have viruses, and more annoying than " +
            //    "finding out that the viruses have disabled your system. " +
            //    "This phenomenon called \"viruses\" emerged many years ago, " +
            //    "the main goal is to harm the computer. Without expanding on" +
            //    " the reasons that cause developers to create and spread viruses " +
            //    "throughout the network, we will understand that we must always be" +
            //    " prepared and protected from viruses. The growth of computing in" +
            //    " the world and the development of operating systems has significantly" +
            //    " increased the amount of high-tech jobs, and this is in order to enable" +
            //    " the development of software and round-the-clock protections against " +
            //    "malicious intentions on the network in the form of viruses or anything " +
            //    "else that ultimately harms our computer. How do you defend yourself?\r\nYour " +
            //    "computer must have antivirus software installed that is always running " +
            //    "(installation of antivirus software can be done by a computer technician," +
            //    " and can also be done by you independently) There are a variety of recommended " +
            //    "antivirus software. The most prominent of them are: Norton Antivirus, McAffe, " +
            //    "Panda , Nod32 Eset. And there is also the antivirus \"AVG\" which offers a free " +
            //    "version free of charge, which provides a reasonable solution. The antivirus software " +
            //    "on the computer takes care of protecting and blocking viruses from entering the computer, " +
            //    "and scans external devices that connect to the computer. Also, the various antiviruses are" +
            //    " updated on the network about viruses New ones that are discovered and distributed and thus" +
            //    " you can maintain constant protection.",new Range(70,290),3,"anti-virus/1.jpg","anti-virus/2.jpg","anti-virus/3.jpg"),
            //new Service(9,"Networking","fixes and sells all networking connections \n In the past, the work of the computer technician" +
            //    " ended with laying the cables in the office, setting up the server and setting up the end stations, today the same" +
            //    " technician needs to know what happens when a guest who wants to connect to " +
            //    "the network wirelessly arrives at the office. Today, a computer technician" +
            //    " needs to know terms such as endpoint security, setting passwords for network" +
            //    " access, where to place wireless routers and even how to set up printers that" +
            //    " are ready to receive jobs remotely, using a Wi-Fi or Bluetooth connection" +
            //    ".\r\n\r\nThe world of computing today is mainly based on mobility. In many " +
            //    "organizations, and certainly in small to medium-sized offices, the stationary " +
            //    "computers are already completely abandoned in favor of laptops. The computer " +
            //    "you work with on the desk in the office is also the one you go to a meeting " +
            //    "with, and also the one you take home, whether for private needs or for further" +
            //    " work.\r\n\r\nThe demands on the communication between the computers, and on the" +
            //    " computer technicians who need to set it up, have changed accordingly. The" +
            //    " employee wants to come to the office, turn on his laptop, and immediately " +
            //    "connect to the network without having to deal with cables and other physical" +
            //    " disturbances. Although in some cases the solution can be a docking" +
            //    " station,\r\nIn many other cases, in order to save money, you want to" +
            //    " be satisfied with the laptop as it is and simply connect and work."
            //    ,new Range(50,300),3,"internet/2.jpg","internet/1.jpg","internet/3.jpg"),
            //new Service(10,"Related products","Sells mice, screens, keyboards,gadjets, etc. i" +
            //    "n the best quality for the best prices. all of the products that help you and you " +
            //    "workers work better, and enjoy your work more.",new Range(30,200),1,
            //    "Related Products/1.jpg","Related Products/2.jpg","Related Products/3.jpg","Related Products/4.jpg"),
        };
    }
}