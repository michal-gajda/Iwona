namespace SampleWebApi.Models
{
    public class Employee
    {
        private readonly List<decimal> grades = new();

        public string Name { get; set; } = string.Empty;
        public decimal? Min
        {
            get
            {
                if (!this.grades.Any())
                {
                    return default;
                }
                else if (grades.Count == 1)
                {
                    return this.grades.First();
                }
                else
                {
                    var min = this.grades.First();

                    foreach (var grade in this.grades)
                    {
                        min = Math.Min(min, grade);
                    }

                    return min;
                }
            }
        }
        public decimal? Max
        {
            get
            {
                if (!this.grades.Any())
                {
                    return default;
                }
                else if (grades.Count == 1)
                {
                    return this.grades.First();
                }
                else
                {
                    var max = this.grades.First();

                    foreach (var grade in this.grades)
                    {
                        max = Math.Max(max, grade);
                    }

                    return max;
                }
            }

        }
        public decimal? Avg
        {
            get
            {
                if (!this.grades.Any())
                {
                    return default;
                }
                else
                {
                    decimal sum = 0m;

                    foreach (var grade in this.grades)
                    {
                        sum += grade;
                    }

                    return sum / this.grades.Count;
                }
            }
        }

        public void AddGrade(string input)
        {
            var grade = input switch
            {
                "1-" => 0.75m,
                "1+" => 1.5m,
                "2-" => 1.75m,
                "2+" => 2.5m,
                "3-" => 2.75m,
                "3+" => 3.5m,
                "4-" => 3.75m,
                "4+" => 4.5m,
                "5-" => 4.75m,
                "5+" => 5.5m,
                "6-" => 5.75m,
                _ => int.Parse(input),
            };

            if (0 <= grade && grade <= 6)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new ArgumentException(nameof(input));
            }
        }
    }
}
