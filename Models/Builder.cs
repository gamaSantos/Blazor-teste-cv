using System;
using System.Collections.Generic;

namespace dinamico
{
    public static class Builder
    {
        public static Curriculum Build()
        {
            var cv = new Curriculum();
            cv.Owner = GetPerson();
            cv.Experiences = GetExperiences();
            cv.Skills = GetSkills();
            cv.Educations = GetEducation();
            return cv;
        }

        private static List<Educations> GetEducation()
        {
            var ed = new List<Educations>();
            ed.Add(new Educations()
            {
                Course = "Análise e Desenvolvimento de Sistemas",
                Institution = "Fatec Zona Sul"
            });
            return ed;
        }

        private static Person GetPerson()
        {
            return new Person
            {
                Name = "Pedro Gama",
                Birthdate = new DateTime(1993, 06, 07),
                Description = "Sou um desenvolvedor de sistemas com experiência principalmente na plataforma .net, posso atuar como fullstack. Atualmente estudando containers e unity3d no tempo livre =)",
                MaritalStatus = "Casado",
                Address = new Address
                {
                    City = "São Paulo, SP",
                    Number = "392",
                    PostalCode = "04824-010",
                    Street = "Av. do Arvoreiro"
                },
                Contact = new ContactInformation
                {
                    Email = "pedro.gama@ymail.com",
                    PhoneNumber = "(11) 95476-5946"
                }
            };
        }

        private static List<Experience> GetExperiences()
        {
            var experiences = new List<Experience>();
            experiences.Add(new Experience
            {
                Name = "Confitec",
                Role = "Desenvolvedor Fullstack Sênior",
                StartDate = new DateTime(2020, 03, 01),
                ExitDate = null,
                Description = 
@"Empresa voltada ao mercado de seguros. Tive a oportunidade de me familiarizar e aperfeiçoar em diversos padrões de mercado como DDD, CQRS e mediators além de obter mais experiencia com sistemas distribuidos",
                Activies = new string[]{
                    "Realizar manutenção e desenvolvimento no produto da empresa.",
                    "Realizar integrações entre sistemas.",
                    "Automatização de processos internos.",
                    "Atualização dos frameworks do produto."
                },
                Technologies = new string[]{
                    "c#", "angular", "sql server", "hangfire", ".net core."
                }
            });

            experiences.Add(new Experience
            {
                Name = "Tabmedia",
                Role = "Desenvolvedor .Net Sênior",
                StartDate = new DateTime(2016, 03, 01),
                ExitDate = new DateTime(2020, 03, 01),
                Description = "Trabalhei em 2 projetos para a indústria farmacêeutica, em um deles pude trabalhar desde a concepção e adquirir maior experiência com DDD e arquitetura de software. Passamos por uma transição para o modelo ágil o que me proporcionou uma boa experiência com scrum.",
                Activies = new string[]{
                    "Realizar manutenção e desenvolvimento no produto da empresa.",
                    "Auxiliar no planejamento de novas funcionalidades.",
                    "Realizar integrações entre sistemas.",
                    "Desenvolvimento de testes unitários."
                },
                Technologies = new string[]{
                    "c#", "sql server", "hangfire", "MVC", "redis", "elastic stack", "aws", "azure", "angular", "electron"
                }
            });

            experiences.Add(new Experience
            {
                Name = "WorldCellos",
                Role = "Desenvolvedor/Sócio",
                StartDate = new DateTime(2013, 10, 01),
                ExitDate = new DateTime(2015, 11, 01),
                Description = "Foi uma pequena consultoria de 4 pessoas, entrei como júnior e fui convidado a virar sócio. Passei a ter mais responsabilidade, como designar tarefas e gerenciar o cronograma dos projetos",
                Activies = new string[]{
                    "Realizar manutenção e desenvolvimento no produto da empresa.",
                    "Auxiliar no planejamento de novas funcionalidades.",
                    "Realizar integrações entre sistemas.",
                    "Desenvolvimento de testes unitários."
                },
                Technologies = new string[]{
                    "c#", "c", "sql server", "MVC", "arduino"
                }
            });
            
            experiences.Add(new Experience
            {
                Name = "Secretária Municipal do Esporte e lazer",
                Role = "Estágiario",
                StartDate = new DateTime(2012, 12, 01),
                ExitDate = new DateTime(2013, 10, 01),
                Description = "Inicio da minha carreira, trabalhei em diversos projetos da intranet da subprefeitura",
                Activies = new string[]{
                    "Realizar manutenção e desenvolvimento no produto da empresa.",
                    "Auxiliar no planejamento de novas funcionalidades.",
                    "Realizar integrações entre sistemas.",
                    "Desenvolvimento de testes unitários."
                },
                Technologies = new string[]{
                    "VB.NET", "postgreSQL", "Web Forms", "ADO.NET"
                }
            });
            
            return experiences;
        }

        private static List<Skill> GetSkills()
        {
            var skills = new List<Skill>();
            skills.Add(new Skill
            {
                Description = "",
                Grade = 85,
                Name = ".net",
                Type = SkillType.Specific
            });
            skills.Add(new Skill
            {
                Description = "",
                Grade = 80,
                Name = "ASP.NET",
                Type = SkillType.Specific
            });
            skills.Add(new Skill
            {
                Description = "",
                Grade = 65,
                Name = "Angular",
                Type = SkillType.Specific
            });

            skills.Add(new Skill
            {
                Description = "",
                Grade = 70,
                Name = "Design Patterns",
                Type = SkillType.Specific
            });

            skills.Add(new Skill
            {
                Description = "",
                Grade = 75,
                Name = "Arquitetura de software",
                Type = SkillType.Specific
            });
            skills.Add(new Skill
            {
                Description = "",
                Grade = 70,
                Name = "Agile",
                Type = SkillType.Specific
            });
            
            skills.Add(new Skill
            {
                Description = "",
                Grade = 70,
                Name = "Bancos Relacionais",
                Type = SkillType.Specific
            });
            skills.Add(new Skill
            {
                Description = "",
                Grade = 62,
                Name = "Bancos NoSQL",
                Type = SkillType.Specific
            });

            skills.Add(new Skill
            {
                Description = "",
                Grade = 40,
                Name = "Containers",
                Type = SkillType.Specific
            });
            skills.Add(new Skill
            {
                Description = "",
                Grade = 60,
                Name = "Aws",
                Type = SkillType.Specific
            });
            skills.Add(new Skill
            {
                Description = "",
                Grade = 50,
                Name = "Azure",
                Type = SkillType.Specific
            });
            skills.Add(new Skill
            {
                Description = "",
                Grade = 77,
                Name = "Inglês",
                Type = SkillType.Soft
            });
            return skills;
        }
    }
}