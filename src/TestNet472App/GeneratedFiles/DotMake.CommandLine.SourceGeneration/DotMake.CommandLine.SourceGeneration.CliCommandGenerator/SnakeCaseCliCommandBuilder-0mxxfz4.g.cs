﻿// <auto-generated />
// Generated by DotMake.CommandLine.SourceGeneration v1.5.7.0
// Roslyn (Microsoft.CodeAnalysis) v4.800.23.57201
// Generation: 1

namespace TestApp.Commands.CasingConvention
{
    public class SnakeCaseCliCommandBuilder : DotMake.CommandLine.CliCommandBuilder
    {
        public SnakeCaseCliCommandBuilder()
        {
            DefinitionType = typeof(TestApp.Commands.CasingConvention.SnakeCaseCliCommand);
            ParentDefinitionType = null;
            NameCasingConvention = DotMake.CommandLine.CliNameCasingConvention.SnakeCase;
            NamePrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.DoubleHyphen;
            ShortFormPrefixConvention = DotMake.CommandLine.CliNamePrefixConvention.SingleHyphen;
            ShortFormAutoGenerate = true;
        }

        public override System.CommandLine.Command Build()
        {
            // Command for 'SnakeCaseCliCommand' class
            var rootCommand = new System.CommandLine.RootCommand()
            {
                Description = "A cli command with snake_case convention",
            };

            var defaultClass = new TestApp.Commands.CasingConvention.SnakeCaseCliCommand();

            // Option for 'Option1' property
            var option0 = new System.CommandLine.Option<string>
            (
                "--option_1",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
                Description = "Description for Option1",
                IsRequired = false,
            };
            option0.SetDefaultValue(defaultClass.Option1);
            option0.AddAlias("-o");
            rootCommand.Add(option0);

            // Argument for 'Argument1' property
            var argument0 = new System.CommandLine.Argument<string>
            (
                "argument_1",
                GetParseArgument<string>
                (
                    null
                )
            )
            {
                Description = "Description for Argument1",
            };
            rootCommand.Add(argument0);

            // Add nested or external registered children
            foreach (var child in Children)
            {
                rootCommand.Add(child.Build());
            }

            BindFunc = (parseResult) =>
            {
                var targetClass = new TestApp.Commands.CasingConvention.SnakeCaseCliCommand();

                //  Set the parsed or default values for the options
                targetClass.Option1 = GetValueForOption(parseResult, option0);

                //  Set the parsed or default values for the arguments
                targetClass.Argument1 = GetValueForArgument(parseResult, argument0);

                return targetClass;
            };

            System.CommandLine.Handler.SetHandler(rootCommand, context =>
            {
                var targetClass = (TestApp.Commands.CasingConvention.SnakeCaseCliCommand) BindFunc(context.ParseResult);

                //  Call the command handler
                targetClass.Run();
            });

            return rootCommand;
        }

        [System.Runtime.CompilerServices.ModuleInitializerAttribute]
        public static void Initialize()
        {
            var commandBuilder = new TestApp.Commands.CasingConvention.SnakeCaseCliCommandBuilder();

            // Register this command builder so that it can be found by the definition class
            // and it can be found by the parent definition class if it's a nested/external child.
            commandBuilder.Register();
        }
    }
}
