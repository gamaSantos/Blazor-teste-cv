using System;
using System.Collections.Generic;

namespace Curriculum.Domain
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
            var desc = "Sou um desenvolvedor de sistemas com experiência principalmente na plataforma .net, mas tambem atuo como  fullstack. Atualmente estudando rust e grpc no tempo livre =)";
            var descEng = "I'm a software developer with solid experience in the .net platform, but I can also work as a fullstack. Currently studying rust and grpc in my spare time =)";
            return new Person
            {
                Name = "Pedro Gama",
                Birthdate = new DateTime(1993, 06, 07),
                Description = new Description(desc, descEng),
                MaritalStatus = new Description("casado", "married"),
                Address = new Address
                {
                    City = "São Paulo, SP",
                    Number = "392",
                    PostalCode = "04824-010",
                    Street = "Av. do Arvoreiro"
                },
                Contact = CreateContactInfo()
            };

            static ContactInformation CreateContactInfo()
            {
                var contactInfo = new ContactInformation
                {
                    Email = "pedro.gama@ymail.com",
                    PhoneNumber = "(11) 95476-5946"
                };

                contactInfo.AddLink(new ContactInformation.ExternalLink("Github", "https://github.com/gamaSantos"));
                contactInfo.AddLink(new ContactInformation.ExternalLink("LinkedIn", "https://www.linkedin.com/in/pedro-gama-6b278662"));
                return contactInfo;
            }
        }

        private static List<Experience> GetExperiences()
        {
            var experiences = new List<Experience>();
            experiences.Add(new Experience
            {
                Name = "Logstore",
                Role = new Description("Desenvolvedor Backend Sênior", "Senior Backend developer"),
                StartDate = new DateTime(2021, 08, 01),
                // ExitDate = new DateTime(2021, 07, 01),
                Description = new Description(
@"Startup voltada para o setor de logistica. Aprendi muito em um ambiente com grande foco na qualidede do software em um sistema orientado a eventos com alto throughput",
@"Small startup with a product. Learned a lot in an environment with high focus in quality and the system throughput using an event oriented architecture"),
                Activies = new string[]{
                    "Realizar manutenção e desenvolvimento no produto da empresa.",
                    "Realizar integrações entre sistemas.",
                    "Automatização de processos internos.",
                    "Atualização dos frameworks do produto."
                },
                Technologies = new string[]{
                    ".net", "angular", "aws", "redis", "aws sqs", "docker"
                }
            });
            experiences.Add(new Experience
            {
                Name = "Confitec",
                Role = new Description("Desenvolvedor Fullstack Sênior", "Senior Fullstack developer"),
                StartDate = new DateTime(2020, 03, 01),
                ExitDate = new DateTime(2021, 07, 01),
                Description = new Description(
@"Empresa voltada ao mercado de seguros. Tive a oportunidade de me familiarizar e aperfeiçoar em diversos padrões de mercado como DDD, CQRS e mediators além de obter mais experiencia com sistemas distribuidos",
@"Company is focused in the insurance market. Had the opportunity to improve in many patterns like CQRS, mediator and DDD whiling acquired experience with distributed systems."),
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
                Role = new Description(
                    "Desenvolvedor .Net Sênior",
                    "Senior .Net developer"),
                StartDate = new DateTime(2016, 03, 01),
                ExitDate = new DateTime(2020, 03, 01),
                Description = new Description(
                    "Trabalhei em 2 projetos para a indústria farmacêutica, em um deles pude trabalhar desde a concepção e adquirir maior experiência com DDD e arquitetura de software. Passamos por uma transição para o modelo ágil o que me proporcionou uma boa experiência com scrum.",
                    "I Worked in two projects to the pharma industry, in the latest, had the opportunity to create the backend from scratch with the tech lead. We transition to a agile method in the company, what gave me solid understing of the culture"),
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
                Role = new Description(
                    "Desenvolvedor / Sócio",
                    "Developer / Partner"),
                StartDate = new DateTime(2013, 10, 01),
                ExitDate = new DateTime(2015, 11, 01),
                Description = new Description(
                    "Foi uma pequena consultoria de 4 pessoas, entrei como júnior e fui convidado a virar sócio. Passei a ter mais responsabilidade, como designar tarefas e gerenciar o cronograma dos projetos",
                    "It was a small consultancy with 4 people, I started as a Junior developer and was invited to work as a parter. I started managing task assignements and projects schedules"),
                Activies = new string[]{
                    "Realizar manutenção e desenvolvimento de varios projetos.",
                    "Gerenciar as tarefas do time.",
                    "Gerenciar cronograma de entrega dos projetos.",
                },
                Technologies = new string[]{
                    "c#", "c", "sql server", "MVC", "arduino"
                }
            });

            experiences.Add(new Experience
            {
                Name = "Secretária Municipal do Esporte e lazer",
                Role = new Description("Estágiario", "Intern"),
                StartDate = new DateTime(2012, 12, 01),
                ExitDate = new DateTime(2013, 10, 01),
                Description = new Description(
                    "Inicio da minha carreira, trabalhei em diversos projetos da intranet da subprefeitura",
                    "In the beginning of my career, worked in diverse internal projects to facilitate and organize the work in the secretary"),
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
                Grade = 58,
                Name = "Angular",
                Type = SkillType.Specific
            });

            skills.Add(new Skill
            {
                Description = "",
                Grade = 77,
                Name = "Design Patterns",
                Type = SkillType.Specific
            });

            skills.Add(new Skill
            {
                Description = "",
                Grade = 76,
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