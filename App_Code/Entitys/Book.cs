﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Book 的摘要说明
/// </summary>
public class Book
{
	public Book()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    private int b_id;   //图书id

    public int B_id {
        get { return b_id; }
        set { b_id = value; }
    }
    private int t_id;   //图书类型

    public int T_id {
        get { return t_id; }
        set { t_id = value; }
    }
    private String b_name;  //图书名称

    public String B_name {
        get { return b_name; }
        set { b_name = value; }
    }
    private int b_no;   //图书编号

    public int B_no {
        get { return b_no; }
        set { b_no = value; }
    }
    private int b_total;    //图书总数

    public int B_total {
        get { return b_total; }
        set { b_total = value; }
    }
    private int b_newnumber;    //图书实时数量

    public int B_newnumber {
        get { return b_newnumber; }
        set { b_newnumber = value; }
    }
    private int b_buildtime;    //图书入库时间

    public int B_buildtime {
        get { return b_buildtime; }
        set { b_buildtime = value; }
    }
}