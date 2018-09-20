using System;

namespace Skyrim___Text_Edition
{
    class Introduction : BaseClass
    {
        public Introduction()
        {
            Text("Press a key...");
            Text(
                "Two hundred years have passed since the Oblivion Crisis, and it is now the year 4E 201." +
                "The High King of Skyrim lies dead, killed by Ulfric Stormcloak in a duel.\n");
            Text(
                "A Civil War rages in the land. A rebel faction known as the Stormcloaks wishes for Skyrim to secede from the Empire. " +
                "However, their cause is not supported by all of the land's people and leaders; many still support the Imperial Army.\n");
            Text(
                "The war has reached a stalemate.\n");
            Text(
                "This schism is the final event in a prophecy of the Elder Scrolls.\n");
            Text(
                "It is foretold that this conflict will lead to the return of the Dragons, led by Alduin, the Nordic God of Destruction, " +
                "also known as the World-Eater.\n");
            Text(
                "Skyrim legend tells of a hero known as the Dragonborn, a warrior with the body of a mortal and soul of a dragon, whose " +
                "destiny it is to destroy the evil dragon Alduin...\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Text(@"
                                                    The Elder Scrolls V
                                _________   _    __  __     __   _____      _    __      __
                               / _______/  | |  / /  \ \   / /  |     \    | |  |  \    /  |
                              / /          | | / /    \ \ / /   |  |>  |   | |  |   \  /   |
                              \ \______    | |/ /      \   /    |    _/    | |  | |\ \/ /| |
                               \______ \   |    \       | |     | |\ \     | |  | | \__/ | |
                                      \ \  | | \ \      | |     | | \ \    | |  | |      | |
                               _______/ /  | |  \ \     | |     | |  \ \   | |  | |      | |
                              /________/   |_|   \_\    |_|     |_|   \_\  |_|  |_|      |_|

                                                       Text Edition








                              ");
            Console.ResetColor();
        }
    }
}
