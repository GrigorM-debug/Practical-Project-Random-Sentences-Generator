string[] names = { "Peter", "Michell", "Jane", "Steve" };
string[] places = { "Sofia", "Plovdiv", "Varna", "Burgas"};
string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
string[] nouns = { "stones", "cake", "apple", "laptop", "bikes"};
string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly"};
string[] details = { "near the river", "at home", "in the park"};


while (true)
{
    string randomName = GetRandomWord(names);
    string randomPlace = GetRandomWord(places);
    string randomVerb = GetRandomWord(verbs);
    string randomNouns = GetRandomWord(nouns);
    string randomAdverbs = GetRandomWord(adverbs);
    string randomDetails = GetRandomWord(details);

    string who = $"{randomName} from {randomPlace}";
    string action = $"{randomAdverbs} {randomVerb} {randomNouns}";
    string sentences = $"{who} {action} {randomDetails}";

    Console.WriteLine(sentences);
    Console.WriteLine("Click [Enter] to generate a new one.");

    Console.ReadLine();
}

string GetRandomWord(string[] words)
{
    Random random = new Random();
    int randomIndex = random.Next(words.Length);
    string word = words[randomIndex];

    return word;
}
