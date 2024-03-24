using System;

namespace ConsoleIeApp1
{
    internal class Program
    {
        static void Main(string[] ags)
        {
            const string СomandCharacterWolfHeroInference = "Характеристики Героя";
            const string СomandCharacterMeowBossInference = "Характеристики Босса";
            const string ComandPotionWolfHeroInference = "Мои зелья";
            const string ComandSkillWolfHeroInference = "Мои навыки";
            const string ComandAttackWolfHero = "Атака";
            const string ComandAttackSkillWolfHero = "Навык 1";
            const string ComandAttackSkillBoomWolfHero = "Навык 2";
            const string ComandHealPontion = "Хилл";
            const string ComandManaPontion = "Мана";
            const string ComandConsoleClear = "Clear";
            const string ComandConsoleExit = "Exit";

            int healthWolfHero = 256112;
            int damageWolfHero = 57603;
            int manaWolfHero = 6070;
            int heroWolfAttackSkill = 86405;
            int heroWolfAttackSkillBoom = 115207;
            int heroWolfManaForSkill = 1214;
            int heroWolfManaForSkillBoom = 3035;
            int healPotion = 128056;
            int manaPotion = 3642;
            int qauantityHealPontion = 5;
            int qauantityManaPintion = 5;
            string namePotionHeal = "Зелье здоровья";
            string namePotionMana = "Зелье маны";
            string nameWolfHeroAttackSkill = "Огненая атака";
            string nameWolfHeroAttackSkillBoom = "Взрыв";

            int meowBossHealtch = 345621;
            int meowBossSkill = 99999999;
            int minAttackMeowBoss = 42685;
            int maxAttackMeowBoss = 85370;
            int doubleAttackIntervalMin = 1;
            int doubleAttackIntervalMax = 3;
            int healBossMeowIntervalMin = 57603;
            int healBossMeowIntervalMax = 115207;
            string nameBossMeowSkill = "Прыжок на лицо";
            string nameBossMeowHealthSkill = "Зализывание ранок";

            Random random = new Random();
            string text;
            char indentation = '\n';
            bool isExit = false;
            bool isSkillAktivadet = false;

            Console.WriteLine($"Добро пожаловать к Киса Боссу!\n" +
                              $"\nТебя ждёт тяжёлое испытание!" +
                              $"\nТебе предстоит управлять своим персонажем, через консоль, путём ввода текста.\n" +
                              $"\nУ тебя есть список команд:\n" +
                              $"\n{СomandCharacterWolfHeroInference} - Показать ваши характеристики;" +
                              $"\n{СomandCharacterMeowBossInference} - Показать характиристики босса;" +
                              $"\n{ComandPotionWolfHeroInference} - Показать ваши зелья;" +
                              $"\n{ComandSkillWolfHeroInference} - Показать список ваших навыков;" +
                              $"\n{ComandAttackWolfHero} - Атака;" +
                              $"\n{ComandAttackSkillWolfHero} - {nameWolfHeroAttackSkill};" +
                              $"\n{ComandAttackSkillBoomWolfHero} - {nameWolfHeroAttackSkillBoom};" +
                              $"\n{ComandHealPontion} - использовать {namePotionHeal};" +
                              $"\n{ComandManaPontion} - использовать {namePotionMana};" +
                              $"\nОтчистить консоль - {ComandConsoleClear};" +
                              $"\nВыход - {ComandConsoleExit}.");

            while (healthWolfHero > 0 && meowBossHealtch > 0 && isExit == false)
            {
                int damageMeowBoss = random.Next(minAttackMeowBoss, maxAttackMeowBoss + 1);
                int doubleAttackMeowBoss = random.Next(doubleAttackIntervalMin, doubleAttackIntervalMax + 1);
                int healBossMeow = random.Next(healBossMeowIntervalMin, healBossMeowIntervalMax + 1);

                Console.WriteLine(indentation);
                text = Console.ReadLine();

                switch (text)
                {
                    case СomandCharacterWolfHeroInference:
                        Console.WriteLine($"\nЗдороьве - {healthWolfHero};" +
                                          $"\nМана - {manaWolfHero};" +
                                          $"\nУрон - {damageWolfHero}.");
                        break;

                    case ComandSkillWolfHeroInference:
                        Console.WriteLine($"\nУ вас есть навык {nameWolfHeroAttackSkill};" +
                                          $"\nОн наносит - {heroWolfAttackSkill} урона;" +
                                          $"\nОн тратит - {heroWolfManaForSkill} очков маны;" +
                                          $"\nНавык {nameWolfHeroAttackSkillBoom};" +
                                          $"\nОн наносит - {heroWolfAttackSkillBoom} урона;" +
                                          $"\nОн тратит - {heroWolfManaForSkillBoom} очков маны." +
                                          $"\n***Можно использовать, после навыка: {nameWolfHeroAttackSkill}***");
                        break;

                    case СomandCharacterMeowBossInference:
                        Console.WriteLine(meowBossHealtch);
                        break;

                    case ComandAttackWolfHero:
                        meowBossHealtch -= damageWolfHero;
                        healthWolfHero -= damageMeowBoss;

                        Console.WriteLine($"\nВаше здоровье - {healthWolfHero};" +
                                          $"\nВаша мана - {manaWolfHero};" +
                                          $"\nЗдорьве Босса - {meowBossHealtch};");
                        break;

                    case ComandPotionWolfHeroInference:
                        Console.WriteLine($"\nУ вас - {qauantityHealPontion} {namePotionHeal};" +
                                          $"\nОдно зелье востанавливает - {healPotion} здоровья;" +
                                          $"\nУ вас - {qauantityManaPintion} {namePotionMana};" +
                                          $"\nОдно зелье востанавливает - {manaPotion} маны.");
                        break;

                    case ComandAttackSkillWolfHero:
                        if (manaWolfHero <= 0)
                        {
                            Console.WriteLine("\nУ вас недостаточно маны!");
                        }
                        else
                        {
                            manaWolfHero -= heroWolfManaForSkill;
                            meowBossHealtch -= heroWolfAttackSkill;
                            healthWolfHero -= damageMeowBoss;
                            isSkillAktivadet = true;
                        }

                        Console.WriteLine($"\nВы применили навык - {nameWolfHeroAttackSkill};" +
                                          $"\nВами полученый урон - {damageMeowBoss};" +
                                          $"\nВаше здоровье - {healthWolfHero};" +
                                          $"\nВаша мана - {manaWolfHero};" +
                                          $"\nЗдорьве Босса - {meowBossHealtch}.");
                        break;

                    case ComandAttackSkillBoomWolfHero:
                        if (manaWolfHero <= 0)
                        {
                            Console.WriteLine("\nУ вас недостаточно маны!");
                        }
                        else if (isSkillAktivadet == false)
                        {
                            healthWolfHero -= damageMeowBoss;

                            Console.WriteLine($"\nВы не можете применить этот навык\n" +
                                              $"\nПока не будет использован {ComandAttackSkillWolfHero};"+
                                              $"\nВами полученый урон - {damageMeowBoss};" +
                                              $"\nВаше здоровье - {healthWolfHero};" +
                                              $"\nВаша мана - {manaWolfHero};" +
                                              $"\nЗдорьве Босса - {meowBossHealtch}.");
                        }
                        else 
                        {
                            manaWolfHero -= heroWolfManaForSkillBoom;
                            meowBossHealtch -= heroWolfAttackSkillBoom;
                            healthWolfHero -= damageMeowBoss * doubleAttackMeowBoss;
                            isSkillAktivadet = false;
                            
                            Console.WriteLine($"\nВы применили навык - {nameWolfHeroAttackSkillBoom + doubleAttackMeowBoss};" +
                                              $"\nВами полученый урон - {damageMeowBoss};" +
                                              $"\nВаше здоровье - {healthWolfHero};" +
                                              $"\nВаша мана - {manaWolfHero};" +
                                              $"\nЗдорьве Босса - {meowBossHealtch}.");
                        }
                        break;

                    case ComandHealPontion:
                        if (qauantityHealPontion == 0)
                        {
                            meowBossHealtch += healBossMeow;
                            Console.WriteLine($"\nУ вас закончились !\n" +
                                              $"\nБосс ипользует навык {nameBossMeowHealthSkill};" +
                                              $"\nИ восстановливает себе {healBossMeow} здоровья;" +
                                              $"\nВаше здоровье - {healthWolfHero};" +
                                              $"\nВаша мана - {manaWolfHero};" +
                                              $"\nЗдорьве Босса - {meowBossHealtch}.");
                        }
                        else
                        {
                            healthWolfHero += healPotion;
                            meowBossHealtch += healBossMeow;

                            Console.WriteLine($"\nВы используете - {namePotionHeal};" +
                                              $"\nИ восстановили себе - {healPotion} здоровья;" +
                                              $"\nИ восстановливает себе {healBossMeow} здоровья;" +
                                              $"\nВаше здоровье - {healthWolfHero};" +
                                              $"\nВаша мана - {manaWolfHero};" +
                                              $"\nЗдорьве Босса - {meowBossHealtch}.");
                            qauantityHealPontion--;
                        }
                        break;

                    case ComandManaPontion:
                            if (qauantityManaPintion == 0)
                            {
                                meowBossHealtch += healBossMeow;
                                Console.WriteLine($"\nУ вас закончились !\n" +
                                                  $"\nБосс ипользует навык {nameBossMeowHealthSkill};" +
                                                  $"\nИ восстановливает себе {healBossMeow} здоровья;" +
                                                  $"\nВаше здоровье - {healthWolfHero};" +
                                                  $"\nВаша мана - {manaWolfHero};" +
                                                  $"\nЗдорьве Босса - {meowBossHealtch}.");
                            }
                            else
                            {
                                manaWolfHero += manaPotion;
                                meowBossHealtch += healBossMeow;

                                Console.WriteLine($"\nВы используете - {namePotionMana};" +
                                                  $"\nИ восстановили себе " +
                                                  $"- {manaPotion} маны;" +
                                                  $"\nБосс ипользует навык {nameBossMeowHealthSkill};" +
                                                  $"\nИ восстановливает себе {healBossMeow} здоровья;" +
                                                  $"\nВаше здоровье - {healthWolfHero};" +
                                                  $"\nВаша мана - {manaWolfHero};" +
                                                  $"\nЗдорьве Босса - {meowBossHealtch}.");
                                qauantityManaPintion--;
                            }
                        break;

                    case ComandConsoleClear:
                        Console.Clear();
                        break;

                    case ComandConsoleExit:
                        isExit = true;
                        break;
                    
                    default:
                        healthWolfHero -= meowBossSkill;

                            Console.WriteLine($"\nЭто была ошибка!\n" +
                                              $"\nБосс на вас использовал навык - {nameBossMeowSkill};" +
                                              $"\nПо вам нанесено - {meowBossSkill} урона;" + 
                                              $"\nВаше здоровье - {healthWolfHero};" +
                                              $"\nВаша мана - {manaWolfHero};" +
                                              $"\nЗдорьве Босса - {meowBossHealtch}.");
                        break;
                }
            }

                if (healthWolfHero <= 0 && meowBossHealtch <= 0)
                {
                    Console.WriteLine($"\nДостигнута ничья!");
                }
                else if (healthWolfHero <= 0)
                {
                    Console.WriteLine($"\nВы унижены!");
                }
                else if (meowBossHealtch <= 0)
                {
                    Console.WriteLine($"Поздравляю!" +
                                      $"\nВы прошли игру!");
                }
        }
    }
}