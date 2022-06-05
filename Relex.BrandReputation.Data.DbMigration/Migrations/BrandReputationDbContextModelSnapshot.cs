﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Relex.BrandReputation.Data.DbContexts;

#nullable disable

namespace Relex.BrandReputation.Data.DbMigration.Migrations
{
    [DbContext(typeof(BrandReputationDbContext))]
    partial class BrandReputationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Relex.BrandReputation.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Review", "Domain");

                    b.HasData(
                        new
                        {
                            Id = new Guid("971bee8e-2854-403b-8a96-7b1605f63062"),
                            Content = "==RUDE== Dude, you are rude upload that carl picture back, or else.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6718), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 17, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6842), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Alison	Blake",
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 31, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6835), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("66a9116a-cc5e-4f4b-b6f2-df1fd71ccf4f"),
                            Content = "== OK! == IM GOING TO VANDALIZE WILD ONES WIKI THEN!!!",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 26, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6861), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 17, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6877), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Zoe	Baker",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 1, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6873), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("bb030157-cb80-4b53-9c42-8a8ead8526d1"),
                            Content = "Stop trolling, zapatancas, calling me a liar merely demonstartes that you arer Zapatancas. You may choose to chase every legitimate editor from this site and ignore me but I am an editor with a record that isnt 99% trolling and therefore my wishes are not to be completely ignored by a sockpuppet like yourself. The consensus is overwhelmingly against you and your trollin g lover Zapatancas,",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6889), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6901), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Victoria	Clarkson",
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 30, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6894), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("584db01e-236e-4b9d-862f-f0f7ca3ee334"),
                            Content = "==You're cool== You seem like a really cool guy... *bursts out laughing at sarcasm*.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6911), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6920), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "David	Hart",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 4, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6916), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("1f9ee90a-b5f3-4df5-87a2-c82e8f1f6b12"),
                            Content = "::::: Why are you threatening me? I'm not being disruptive, its you who is being disruptive.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 27, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6932), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6942), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "David	Hill",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 5, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6936), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("cd9ab33c-a45a-4085-a6df-a5e5f3a6c5c0"),
                            Content = "::::::::::I'm not sure either. I think it has something to do with merely ahistorical vs being derived from pagan myths. Price does believe the latter, I'm not sure about other CMT proponents.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6954), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 23, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6965), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Amelia	Manning",
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 31, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6961), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("a07765bf-5631-4524-9d76-9a7e3c463057"),
                            Content = "::::I heard Mark Kermode say today that Turbo was rubbish, and he's never *cough* wrong! He doesn't like F1 but he loved Senna and liked Rush as well.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 22, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6975), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6986), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Benjamin	Ross",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 5, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6980), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("c51d59c2-6647-4578-9704-0730dc71cecf"),
                            Content = "It is a shame what people are here, I am disgusting of you.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 24, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(6996), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7005), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Tracey	Hill",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 1, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7001), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("bf34b132-dea4-4a68-aabf-4290f0d4b150"),
                            Content = "== my removal of your content on DNA melting == I removed the content you placed when creating the article because it was wrong and unreferenced. Mutations do not have 'weird structures' a point mutation might start with a single nucleotide mismatch, but those are rapidly detected and repaired to form a stable bonded double-helix structure, and subsequent rounds of DNA replication match each base with its complement. Perhaps your wording was wrong, perhaps you were thinking of an obscure related technology that I have heard of, but you didn't give a reference and I'm not going to help you with this, because you're being rude. I find it disturbing that you apparently made this scientific page on wikipedia claiming a statement of fact that was in merely based on your own speculations.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 23, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7017), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 16, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7026), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Joanne	Avery",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 1, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7022), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("af1ee3be-8530-40d1-85d2-dd7522ba3e35"),
                            Content = "I suggest you kill yourself.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7037), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 16, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7048), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Andrea	Sharp",
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 27, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("301204e2-ff74-4452-81a9-07149daf682b"),
                            Content = "Get yourself some help.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 23, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7058), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 25, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7069), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Victor	Lee",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 2, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7062), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("f7ad5597-2da9-4285-8812-3372b7acf820"),
                            Content = "Yes, I was blocked for losing patience with you, and what I did then would constitute personal attack. Honest outspoken criticism that is based on fact is permitted though, and the shameless hate speech expressed here deserves more than just vocal criticism. As for you, I'll discuss you elsewhere. This isn't the place for that.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7081), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7091), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Angela	Marshall",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 2, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7086), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("3beaf95c-8256-492b-b42c-1f816b89d315"),
                            Content = "See the section below about the Macedonian last names, and common endings of the Macedonian last names, as well some common endings of the last names in the Slavic Languages.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7103), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7112), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Rose	Oliver",
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 27, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7108), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e8ae7f4c-62c5-4b41-b4e7-22e57e4f57fd"),
                            Content = ": I know you listed your English as on the level 2, but don't worry, you seem to be doing nicely otherwise, judging by the same page - so don't be taken aback. I just wanted to know if you were aware of what you wrote, and think it's an interesting case. : I would write that sentence simply as 'Theoretically I am an altruist, but only by word, not by my actions.'. : PS. You can reply to me on this same page, as I have it on my watchlist.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7122), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 19, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7133), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Dan	Parsons",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 3, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("18e87ce1-dff4-4746-b84c-93c4ce671086"),
                            Content = "::I agree. Trolling snitches should be protected. Where are these days when crybabies just haven't been payed attention to ? Eh, I'm waxing nostalgic....",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7144), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7155), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "David	Pullman",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 4, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7148), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("7766d469-a916-4d46-8727-d77301bbda7f"),
                            Content = "OH MY just CALL THEM ROCK YOU IDIOTS!!!!",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 18, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7167), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 20, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7176), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Vanessa	Langdon",
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 31, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7171), new TimeSpan(0, 4, 30, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("fa1ffed7-10d8-4996-ad25-91b47f937178"),
                            Content = "::Somebody, go write one. Do it yourself lazy.",
                            CreatedDate = new DateTimeOffset(new DateTime(2022, 5, 21, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7187), new TimeSpan(0, 4, 30, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 6, 17, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7195), new TimeSpan(0, 4, 30, 0, 0)),
                            Name = "Eric	Berry",
                            StartDate = new DateTimeOffset(new DateTime(2022, 6, 4, 0, 30, 50, 578, DateTimeKind.Unspecified).AddTicks(7191), new TimeSpan(0, 4, 30, 0, 0))
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
