using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relex.BrandReputation.Data.Seeders
{
    internal class ReviewSeeder
    {
        public static IEnumerable<Review> Seed()
        {
            yield return
                 new Review("Alison	Blake", "==RUDE== Dude, you are rude upload that carl picture back, or else.")
                 {
                     Id = Guid.Parse("{971BEE8E-2854-403B-8A96-7B1605F63062}"),
                     CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                     StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                     EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                 };

            yield return
                 new Review("Zoe	Baker", "== OK! == IM GOING TO VANDALIZE WILD ONES WIKI THEN!!!")
                 {
                     Id = Guid.Parse("{66A9116A-CC5E-4F4B-B6F2-DF1FD71CCF4F}"),
                     CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                     StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                     EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                 };

            yield return
                  new Review("Victoria	Clarkson", "Stop trolling, zapatancas, calling me a liar merely demonstartes that you arer Zapatancas. You may choose to chase every legitimate editor from this site and ignore me but I am an editor with a record that isnt 99% trolling and therefore my wishes are not to be completely ignored by a sockpuppet like yourself. The consensus is overwhelmingly against you and your trollin g lover Zapatancas,")
                  {
                      Id = Guid.Parse("{BB030157-CB80-4B53-9C42-8A8EAD8526D1}"),
                      CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                      StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                      EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                  };

            yield return
                   new Review("David	Hart", "==You're cool== You seem like a really cool guy... *bursts out laughing at sarcasm*.")
                   {
                       Id = Guid.Parse("{584DB01E-236E-4B9D-862F-F0F7CA3EE334}"),
                       CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                       StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                       EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                   };

            yield return
                    new Review("David	Hill", "::::: Why are you threatening me? I'm not being disruptive, its you who is being disruptive.")
                    {
                        Id = Guid.Parse("{1F9EE90A-B5F3-4DF5-87A2-C82E8F1F6B12}"),
                        CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                        StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                        EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                    };

            yield return
                     new Review("Amelia	Manning", "::::::::::I'm not sure either. I think it has something to do with merely ahistorical vs being derived from pagan myths. Price does believe the latter, I'm not sure about other CMT proponents.")
                     {
                         Id = Guid.Parse("{CD9AB33C-A45A-4085-A6DF-A5E5F3A6C5C0}"),
                         CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                         StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                         EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                     };

            yield return
                      new Review("Benjamin	Ross", "::::I heard Mark Kermode say today that Turbo was rubbish, and he's never *cough* wrong! He doesn't like F1 but he loved Senna and liked Rush as well.")
                      {
                          Id = Guid.Parse("{A07765BF-5631-4524-9D76-9A7E3C463057}"),
                          CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                          StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                          EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                      };

            yield return
                       new Review("Tracey	Hill", "It is a shame what people are here, I am disgusting of you.")
                       {
                           Id = Guid.Parse("{C51D59C2-6647-4578-9704-0730DC71CECF}"),
                           CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                           StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                           EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                       };

            yield return
                        new Review("Joanne	Avery", "== my removal of your content on DNA melting == I removed the content you placed when creating the article because it was wrong and unreferenced. Mutations do not have 'weird structures' a point mutation might start with a single nucleotide mismatch, but those are rapidly detected and repaired to form a stable bonded double-helix structure, and subsequent rounds of DNA replication match each base with its complement. Perhaps your wording was wrong, perhaps you were thinking of an obscure related technology that I have heard of, but you didn't give a reference and I'm not going to help you with this, because you're being rude. I find it disturbing that you apparently made this scientific page on wikipedia claiming a statement of fact that was in merely based on your own speculations.")
                        {
                            Id = Guid.Parse("{BF34B132-DEA4-4A68-AABF-4290F0D4B150}"),
                            CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                            StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                            EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                        };

            yield return
                         new Review("Andrea	Sharp", "I suggest you kill yourself.")
                         {
                             Id = Guid.Parse("{AF1EE3BE-8530-40D1-85D2-DD7522BA3E35}"),
                             CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                             StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                             EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                         };

            yield return
                         new Review("Victor	Lee", "Get yourself some help.")
                         {
                             Id = Guid.Parse("{301204E2-FF74-4452-81A9-07149DAF682B}"),
                             CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                             StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                             EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                         };

            yield return
                           new Review("Angela	Marshall", "Yes, I was blocked for losing patience with you, and what I did then would constitute personal attack. Honest outspoken criticism that is based on fact is permitted though, and the shameless hate speech expressed here deserves more than just vocal criticism. As for you, I'll discuss you elsewhere. This isn't the place for that.")
                           {
                               Id = Guid.Parse("{F7AD5597-2DA9-4285-8812-3372B7ACF820}"),
                               CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                               StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                               EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                           };
            yield return
                            new Review("Rose	Oliver", "See the section below about the Macedonian last names, and common endings of the Macedonian last names, as well some common endings of the last names in the Slavic Languages.")
                            {
                                Id = Guid.Parse("{3BEAF95C-8256-492B-B42C-1F816B89D315}"),
                                CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                                StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                                EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                            };

            yield return
                             new Review("Dan	Parsons", ": I know you listed your English as on the level 2, but don't worry, you seem to be doing nicely otherwise, judging by the same page - so don't be taken aback. I just wanted to know if you were aware of what you wrote, and think it's an interesting case. : I would write that sentence simply as 'Theoretically I am an altruist, but only by word, not by my actions.'. : PS. You can reply to me on this same page, as I have it on my watchlist.")
                             {
                                 Id = Guid.Parse("{E8AE7F4C-62C5-4B41-B4E7-22E57E4F57FD}"),
                                 CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                                 StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                                 EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                             };
            yield return
                            new Review("David	Pullman", "::I agree. Trolling snitches should be protected. Where are these days when crybabies just haven't been payed attention to ? Eh, I'm waxing nostalgic....")
                            {
                                Id = Guid.Parse("{18E87CE1-DFF4-4746-B84C-93C4CE671086}"),
                                CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                                StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                                EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                            };

            yield return
                            new Review("Vanessa	Langdon", "OH MY just CALL THEM ROCK YOU IDIOTS!!!!")
                            {
                                Id = Guid.Parse("{7766D469-A916-4D46-8727-D77301BBDA7F}"),
                                CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                                StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                                EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                            };

            yield return
                            new Review("Eric	Berry", "::Somebody, go write one. Do it yourself lazy.")
                            {
                                Id = Guid.Parse("{FA1FFED7-10D8-4996-AD25-91B47F937178}"),
                                CreatedDate = DateTime.Now.AddDays(-10 - new Random().Next(10)),
                                StartDate = DateTime.Now.AddDays(-10 + new Random().Next(10)),
                                EndDate = DateTime.Now.AddDays(10 + new Random().Next(10))
                            };

        }
    }
}
