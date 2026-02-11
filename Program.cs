/*
    KEY: 
        SP - Solarpunk [Story seed library]
        NGA - Classic painting [National gallary of art]
        Ink - Inktober
        fan - Fantassy inspired art
*/

//all pictures
List<string> allPics = [
    "1. Solar Ascension (SP)",
    "2. Victory (SP)",
    "3. Solarpunk lab (SP)",
    "4. The floating village (SP)",
    "5. Earth collage - utopia 2048 (SP)",
    "6. How to build a solar punk city (SP)",
    "7. A harvester of knowledge (SP)",
    "8. Subak: water irrigation system (SP)",
    "9. Still Life with Artichokes and a parrot (NGA)",
    "10. Basilica constantine doric colonnade (NGA)",
    "11. Lady Cunliffe(NGA)",
    "12. View la cava (NGA)",
    "13. Queen henirietta maria sir jeffrey hudson (NGA)",
    "14. Philosopher (NGA)",
    "15. Roses (NGA)",
    "16. Washington valley forge (NGA)",
    "17. Ripe (Ink: holm)",
    "18. Troll attack (Ink: Higgins)",
    "19. Bone (Ink: Hedge)",
    "20. Error (Ink: Birelmann)",
    "21. Holidays (Fan: P&C)",
    "22. Elijah the rainbow dream dragon (Fan:Kayas )",
    "23. Slime girl (Fan: Remmade)",
    "24. Sara- manga Style (Fan: Lilou)",
    "25. Concept game (Fan: Dadsky)",

    "AI.1. Solar Ascension ",
    "AI.2. Victory ",
    "AI.3. Solarpunk lab ",
    "AI.4. The floating village ",
    "AI.5. Earth collage - utopia 2048 ",
    "AI.6. How to build a solar punk city ",
    "AI.7. A harvester of knowledge ",
    "AI.8. Subak: water irrigation system ",
    "AI.9. Still Life with Artichokes and a parrot ",
    "AI.10. Basilica constantine doric colonnade ",
    "AI.11. Lady Cunliffe",
    "AI.12. View la cava ",
    "AI.13. Queen henirietta maria sir jeffrey hudson ",
    "AI.14. Philosopher ",
    "AI.15. Roses ",
    "AI.16. Washington valley forge ",
    "AI.17. Ripe ",
    "AI.18. Troll attack ",
    "AI.19. Bone ",
    "AI.20. Error ",
    "AI.21. Holidays ",
    "AI.22. Elijah the rainbow dream dragon ",
    "AI.23. Slime girl ",
    "AI.24. Sara - Manga Style",
    "AI.25. Concept art Game",
];


Console.WriteLine("Randomly generated order");

//Counters for AI and Human pictures respectivly 
int aiCount = 0;
int humnaCount = 0;

// Loop until 40 pictures has been chosen
for (var i = 0; i < 40; i++)
{
    // Randomly chosen index 
    int index = Random.Shared.Next(0, allPics.Count);

    // Checks if the chosen picture index is AI or not 
    if (allPics[index].Contains("AI"))
    {
        // Change colour for easier reading and advances the counter 
        Console.ForegroundColor = ConsoleColor.Red;
        aiCount++;
    }
    else
    {
        // Same as above 
        Console.ForegroundColor = ConsoleColor.Blue;
        humnaCount++;
    }
    // Writes the chosen picture
    Console.WriteLine(allPics[index]);
    // Remove so it can't be chosen again 
    allPics.RemoveAt(index);
}
// Resets the text colour 
Console.ForegroundColor = ConsoleColor.White;
// Writes out the amount human and AI pictures and the total amount for dubble checking.
Console.WriteLine($"Total pictures: {humnaCount + aiCount}. human: {humnaCount}, Ai: {aiCount}");

// The first output(when finsihed) having equal amount AI and Human pictures. Also the final order.
/* 
Randomly generated order
14. Philosopher (NGA)
15. Roses (NGA)
AI.6. How to build a solar punk city
1. Solar Ascension (SP)
19. Bone (Ink: Hedge)
AI.12. View la cava
2. Victory (SP)
AI.4. The floating village
16. Washington valley forge (NGA)
6. How to build a solar punk city (SP)
AI.14. Philosopher
AI.18. Troll attack
AI.9. Still Life with Artichokes and a parrot
AI.11. Lady Cunliffe
AI.5. Earth collage - utopia 2048
7. A harvester of knowledge (SP)
AI.10. Basilica constantine doric colonnade
3. Solarpunk lab (SP)
11. Lady Cunliffe(NGA)
12. View la cava (NGA)
18. Troll attack (Ink: Higgins)
AI.17. Ripe
AI.2. Victory
13. Queen henirietta maria sir jeffrey hudson (NGA)
AI.7. A harvester of knowledge
10. Basilica constantine doric colonnade (NGA)
AI.3. Solarpunk lab
AI.13. Queen henirietta maria sir jeffrey hudson
23. Slime girl (Fan: Remmade)
AI.8. Subak: water irrigation system
AI.16. Washington valley forge
AI.22. Elijah the rainbow dream dragon
24. Sara- manga Style (Fan: Lilou)
AI.25. Concept art Game
4. The floating village (SP)
8. Subak: water irrigation system (SP)
22. Elijah the rainbow dream dragon (Fan:Kayas )
AI.21. Holidays
AI.23. Slime girl
25. Concept game (Fan: Dadsky)
Total pictures: 40. human: 20, Ai: 20
 */