﻿namespace SpecFlow.Variants.UnitTests
{
    internal static class SampleFeatureFile
    {
        public const string Variant = "Variant";
        public const string FeatureTitle = "This is a feature";
        public const string ScenarioTitle_Plain = "A scenario with no tags or exampes";
        public const string ScenarioTitle_Tags = "A scenario with variant and regular tags";
        public const string ScenarioTitle_TagsAndExamples = "A scenario with variant tags and examples";
        public const string ScenarioTitle_TagsExamplesAndInlineData = "A scenario with examples, inline table and text";

        public static readonly string[] Variants = { "Chrome", "Firefox", "IE", "Opera" };

        public static readonly string FeatureFileDocument = $@"
            Feature: {FeatureTitle}
            
            @Reg
            Scenario: {ScenarioTitle_Plain}
                Given some setup
                When something happens
                Then there should be some 
            
            @{Variant}:{Variants[0]}
            @{Variant}:{Variants[1]}
            @{Variant}:{Variants[2]}
            @{Variant}:{Variants[3]}
            @Reg
            @Config:Temp
            Scenario: {ScenarioTitle_Tags}
                Given some setup
                When something happens
                Then there should be some
            
            @{Variant}:{Variants[0]}
            @{Variant}:{Variants[1]}
            @{Variant}:{Variants[2]}
            @{Variant}:{Variants[3]}
            @Reg
            @Config:Temp
            Scenario Outline: {ScenarioTitle_TagsAndExamples}
                Given some setup
                When <this> happens
                Then <that> is the result
            Examples:
                | this | that |
                | one  | 1    |
                | two  | 2    |

            Scenario Outline: {ScenarioTitle_TagsExamplesAndInlineData}
                Given some setup
                    """"""
                    Long text
                    """"""
                When <this> happens
                And a table exists
                | header | headerB |
                | cell   | cellB   |
                Then <that> is the result
            Examples:
                | this | that |
                | one  | 1    |
                | two  | 2    |";
    }
}