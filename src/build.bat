cd DreamCompiler
SET CLASSPATH=.\jars\antlr-4.7.1-complete.jar;%CLASSPATH%
java org.antlr.v4.Tool -Dlanguage=CSharp .\grammar\DreamGrammar.g4 -no-listener -visitor -package DreamCompiler.Grammar
cd ..