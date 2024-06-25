namespace DataPartitioning
{
    public class Article
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }

        // Fetch Articles
        public static IEnumerable<Article> FetchArticles()
        {
            return new List<Article>()
            {
                new Article{ Id = 1, Title = "Programming", Description = "About Programming" },
                new Article{ Id = 2, Title = "C-Sharp", Description = "C# is a powerfull programmiong language" },
                new Article{ Id = 3, Title = "Problem Solving", Description = "About Problem Solving" },
                new Article{ Id = 4, Title = "TypeScript", Description = "Typescript is superset of Javascript" },
                new Article{ Id = 5, Title = "Angular", Description = "Angular is a frontend framework" },
                new Article{ Id = 6, Title = "Next JS", Description = "About Next JS" },
                new Article{ Id = 7, Title = "Data Structure", Description = "Data Structure & Algorithm" },
                new Article{ Id = 8, Title = "React JS", Description = "React JS is a popular frontend library" },
                new Article{ Id = 9, Title = "Node JS", Description = "Javascript runtime on server" },
                new Article{ Id = 10, Title = "OOP in C#", Description = "Learn OOP with C#" },
                new Article{ Id = 11, Title = "Redux", Description = "About Redux" },
                new Article{ Id = 12, Title = "Linux", Description = "Linux operating system" },
                new Article{ Id = 13, Title = "Unit Testing", Description = "About Unit Testing" },
                new Article{ Id = 14, Title = "Java", Description = "Java is a powerfull programming language" },
                new Article{ Id = 15, Title = "PHP", Description = "PHP is a powerfull programming language in web development" },
                new Article{ Id = 16, Title = "SQL Server", Description = "About SQL Server" },
                new Article{ Id = 17, Title = "Mongo DB", Description = "About Mongo DB" },
                new Article{ Id = 18, Title = "Web API", Description = "About Web API" },
                new Article{ Id = 19, Title = "HTTP Protocol", Description = "About HTTP Protocol" },
                new Article{ Id = 20, Title = "View JS", Description = "View JS is a frontend framework" },
                new Article{ Id = 21, Title = "Postgresql", Description = "About Postgresql" },
                new Article{ Id = 22, Title = "MySQL", Description = "About MySQL" },
                new Article{ Id = 23, Title = "Javascript", Description = "About Javascript" },
                new Article{ Id = 24, Title = "Html & CSS & JS", Description = "Frontend Development" },
                new Article{ Id = 25, Title = "Bootstrap", Description = "CSS Framework" },
                new Article{ Id = 26, Title = "ASP.NET MVC", Description = "About ASP.NET MVC" },
                new Article{ Id = 27, Title = "Express JS", Description = "Framework for building web apps with JS" },
                new Article{ Id = 28, Title = "React Router Dom", Description = "About RRD" },
                new Article{ Id = 29, Title = "C Plus Plus", Description = "About C++" },
                new Article{ Id = 30, Title = "Python", Description = "About Python" },
                new Article{ Id = 31, Title = "Django", Description = "About Django" },
                new Article{ Id = 32, Title = "GoLang", Description = "About GoLnag" },
                new Article{ Id = 33, Title = "Java Spring Framework", Description = "About Java Spring Framework" },
                new Article{ Id = 34, Title = "Nest JS", Description = "About Nest JS" },
                new Article{ Id = 35, Title = "OOP in JAVA", Description = "About OOP in Java" },
                new Article{ Id = 36, Title = "Lamda Expression", Description = "About Lambda Expression in C#" },
                new Article{ Id = 37, Title = "Web Development", Description = "About Web Development" },
                new Article{ Id = 38, Title = "CSS Animation", Description = "About CSS Animation" },
                new Article{ Id = 39, Title = "CSS Flex Box", Description = "About CSS Flex Box" },
                new Article{ Id = 40, Title = "Web Socket", Description = "About Web Socket" },
            };
        }
    }
}
