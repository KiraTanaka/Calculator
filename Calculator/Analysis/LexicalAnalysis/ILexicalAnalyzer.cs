﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCalculator.Tokens;

namespace ConsoleCalculator.Analysis.LexicalAnalysis
{
    public interface ILexicalAnalyzer
    {
        List<Token> Analysis(string expression);
    }
}
