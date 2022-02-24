using System;

Main();

void Main() {
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!\n--------------------------------------------");
    Console.WriteLine();
    MooseSays("HI, I'M ENTHUSIASTIC!");
    MooseSays("I really am enthusiastic");

    MooseAsks("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    MooseAsks("Are you enthusiastic?", "Yay!", "You should try it!");
    MooseAsks("Do you like my friend?", "I do too. They're very nice.", "Give them a fair shake. Just say hello.");
    MooseAsks("I can see you.", "...", "...");
    MooseAsks("Do you know where I am?", "Hello there.", "You will soon.");
    MooseAsks("My friend wants to shake your hand.", "....", "..........");
    MooseAsks("You smell nice.", "~~~~", "....");
}

void MooseSays(string message) {
        Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question, string yesResponse, string noResponse) {
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n") {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y") {
        MooseSays(yesResponse);
    } else {
        MooseSays(noResponse);
    }
}