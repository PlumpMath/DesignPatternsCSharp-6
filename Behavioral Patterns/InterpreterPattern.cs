using System;
using System.Collections;
 

  /// <summary>
  /// MainApp startup class for Structural 
  /// Definintion - Interpreter Design Pattern - 
//    Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      Context context = new Context();
 
      // Usually a tree 
      ArrayList list = new ArrayList();
 
      // Populate 'abstract syntax tree' 
      list.Add(new TerminalExpression());
      list.Add(new NonterminalExpression());
      list.Add(new TerminalExpression());
      list.Add(new TerminalExpression());
 
      // Interpret
      foreach (AbstractExpression exp in list)
      {
        exp.Interpret(context);
      }
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Context' class
  /// </summary>
  class Context
  {
  }
 
  /// <summary>
  /// The 'AbstractExpression' abstract class
  /// </summary>
  abstract class AbstractExpression
  {
    public abstract void Interpret(Context context);
  }
 
  /// <summary>
  /// The 'TerminalExpression' class
  /// </summary>
  class TerminalExpression : AbstractExpression
  {
    public override void Interpret(Context context)
    {
      Console.WriteLine("Called Terminal.Interpret()");
    }
  }
 
  /// <summary>
  /// The 'NonterminalExpression' class
  /// </summary>
  class NonterminalExpression : AbstractExpression
  {
    public override void Interpret(Context context)
    {
      Console.WriteLine("Called Nonterminal.Interpret()");
    }
  }
