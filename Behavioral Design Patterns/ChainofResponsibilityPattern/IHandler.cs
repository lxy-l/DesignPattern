﻿namespace ChainofResponsibilityPattern;

public interface IHandler
{
    IHandler SetNext(IHandler handler);

    object Handle(object request);
}