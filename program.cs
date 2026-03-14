<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Random Noragen Word</title>
    <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #1e1e1e;
            color: #f0f0f0;
            font-family: Arial, sans-serif;
            font-size: 2rem;
        }
        .word-box {
            padding: 20px 40px;
            background-color: #333;
            border-radius: 12px;
            box-shadow: 0 0 15px rgba(0,0,0,0.5);
        }
    </style>
</head>
<body>
    <div class="word-box" id="wordDisplay">Loading...</div>

    <script>
        // List of 100 Noragen words
        const noragenWords = [
            "Aelir", "Brenok", "Cyra", "Dovak", "Erynd", "Fynra", "Gorath", "Helys", "Ithran", "Jorvik",
            "Krynn", "Lysera", "Myrrh", "Nyros", "Oryth", "Pyrral", "Qyven", "Rylar", "Sythe", "Toryn",
            "Ulvak", "Voryn", "Wyrin", "Xylar", "Yveth", "Zorath", "Alrik", "Branis", "Celyth", "Daryth",
            "Eryth", "Fynrik", "Gryth", "Hyral", "Ilyth", "Jorath", "Kylen", "Lyric", "Myral", "Nyveth",
            "Olyra", "Pyrik", "Quorin", "Rynal", "Syveth", "Tyran", "Ulric", "Vyral", "Wyrath", "Xyric",
            "Ylvan", "Zyrel", "Aryn", "Bryth", "Cyrik", "Dralin", "Elyra", "Fyral", "Gryrik", "Helyth",
            "Iryth", "Jyral", "Kyrik", "Lyran", "Myric", "Noryn", "Oryth", "Pryth", "Qyric", "Rylik",
            "Syric", "Toryth", "Uryth", "Vyrik", "Wylth", "Xyryn", "Yryth", "Zyrik", "Alryn", "Bryrik",
            "Cyral", "Dyrik", "Elyth", "Fyrik", "Gryth", "Hyrik", "Ilyrik", "Joryn", "Kyveth", "Loryn",
            "Mythra", "Nyrik", "Olyth", "Pryrik", "Qyral", "Roryn", "Syryk", "Toryk", "Ulyth", "Voryth"
        ];

        // Pick a random word
        const randomWord = noragenWords[Math.floor(Math.random() * noragenWords.length)];

        // Display the word
        document.getElementById('wordDisplay').textContent = randomWord;
    </script>
</body>
</html>
