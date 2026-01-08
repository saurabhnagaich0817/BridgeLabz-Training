using System;

class UserNode
{
    public int userId;
    public string name;
    public int age;
    public string friends;  
    public UserNode next;
}

class SocialList
{
    UserNode head;

 
    public void AddUser(int id, string name, int age)
    {
        UserNode u = new UserNode();
        u.userId = id;
        u.name = name;
        u.age = age;
        u.friends = "";
        u.next = head;
        head = u;
    }


    UserNode FindById(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.userId == id)
                return temp;
            temp = temp.next;
        }
        return null;
    }

  
    public void SearchByName(string name)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.name == name)
            {
                Show(temp);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("User not found");
    }

   
    public void AddFriend(int id1, int id2)
    {
        UserNode u1 = FindById(id1);
        UserNode u2 = FindById(id2);

        if (u1 == null || u2 == null) return;

        u1.friends += id2 + ",";
        u2.friends += id1 + ",";
    }

    
    public void RemoveFriend(int id1, int id2)
    {
        UserNode u1 = FindById(id1);
        UserNode u2 = FindById(id2);

        if (u1 == null || u2 == null) return;

        u1.friends = u1.friends.Replace(id2 + ",", "");
        u2.friends = u2.friends.Replace(id1 + ",", "");
    }

   
    public void ShowFriends(int id)
    {
        UserNode u = FindById(id);
        if (u == null) return;

        Console.WriteLine("Friends of " + u.name + ": " + u.friends);
    }

    
    public void MutualFriends(int id1, int id2)
    {
        UserNode u1 = FindById(id1);
        UserNode u2 = FindById(id2);

        if (u1 == null || u2 == null) return;

        string[] f1 = u1.friends.Split(',', StringSplitOptions.RemoveEmptyEntries);
        string[] f2 = u2.friends.Split(',', StringSplitOptions.RemoveEmptyEntries);

        Console.Write("Mutual Friends: ");
        foreach (string a in f1)
        {
            foreach (string b in f2)
            {
                if (a == b)
                    Console.Write(a + " ");
            }
        }
        Console.WriteLine();
    }

   
    public void CountFriends()
    {
        UserNode temp = head;
        while (temp != null)
        {
            int count = 0;
            if (temp.friends != "")
                count = temp.friends.Split(',', StringSplitOptions.RemoveEmptyEntries).Length;

            Console.WriteLine(temp.name + " has " + count + " friends");
            temp = temp.next;
        }
    }

    void Show(UserNode u)
    {
        Console.WriteLine(u.userId + " " + u.name + " " + u.age);
    }
}

class Program
{
    static void Main()
    {
        SocialList s = new SocialList();

        s.AddUser(1, "Aman", 20);
        s.AddUser(2, "Ravi", 21);
        s.AddUser(3, "Neha", 19);

        s.AddFriend(1, 2);
        s.AddFriend(1, 3);

        s.ShowFriends(1);
        s.MutualFriends(2, 3);
        s.CountFriends();

        s.RemoveFriend(1, 2);
        s.ShowFriends(1);
    }
}
