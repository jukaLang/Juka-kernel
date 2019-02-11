﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamCompiler.RoslynCompile
{
    using Antlr4.Runtime.Tree;
    using Antlr4.Runtime;
    using DreamCompiler.Grammar;
    using DreamCompiler.Visitors;
    using Microsoft.CodeAnalysis;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using System.Diagnostics;

    internal class GenerateIfStatement
    {
        internal GenerateIfStatement()
        {

        }

        internal CSharpSyntaxNode IfStatement()
        {
            return null;
        }

        internal GenerateIfStatement Walk(ParserRuleContext node, DreamRoslynVisitor visitor)
        {
            int count = node.ChildCount - 2;

            var ifNode = node.children[0];
            var leftParen = node.children[1];

            ExpressionSyntax expression = null;
            StatementSyntax statementSyntax = null;

            for (int i = 2; i < count; i++)
            {
                expression = node.children[i].Accept(visitor) as ExpressionSyntax;
            }

            var ifStatement = SyntaxFactory.IfStatement(expression, statementSyntax);
            //SyntaxFactory.FieldDeclaration(SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxTriviaList.Create()))

            return this;
        }
    }
}
