//MVC (Model-View-Controller)

using System;

public class UserModel
{
    public string Username { get; set; }
    public string Email { get; set; }
}

public class UserView
{
    public void DisplayUserDetails(UserModel user)
    {
        Console.WriteLine($"User Details: {user.Username}, {user.Email}");
    }
}

public class UserController
{
    private readonly UserModel user;
    private readonly UserView userView;

    public UserController(UserModel userModel, UserView userView)
    {
        this.user = userModel;
        this.userView = userView;
    }

    public void SetUserDetails(string username, string email)
    {
        user.Username = username;
        user.Email = email;
    }

    public UserModel GetUserDetails()
    {
        return user;
    }

    public void UpdateView()
    {
        userView.DisplayUserDetails(user);
    }
}

class Program
{
    static void Main()
    {
        UserModel userModel = new UserModel { Username = "Dima", Email = "dima@tet.com" };
        UserView userView = new UserView();
        UserController userController = new UserController(userModel, userView);

        userController.UpdateView();

        userController.SetUserDetails(username: "Anton", email: "anton@tet.com");

        userController.UpdateView();
    }
}
