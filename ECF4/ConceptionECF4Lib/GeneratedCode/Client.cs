﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Client
{
	public virtual int num_client
	{
		get;
		set;
	}

	public virtual string nom_client
	{
		get;
		set;
	}

	public virtual string adresse_client
	{
		get;
		set;
	}

	public virtual int cp_client
	{
		get;
		set;
	}

	public virtual string ville_client
	{
		get;
		set;
	}

	public virtual string tel_client
	{
		get;
		set;
	}

    public Client (int numcli, string nomcli, string adrcli, int cpcli, string vilcli, string telcli)
    {
        num_client = numcli;
        nom_client = nomcli;
        adresse_client = adrcli;
        cp_client = cpcli;
        ville_client = vilcli;
        tel_client = telcli;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}", nom_client, ville_client, tel_client);
    }

    public override bool Equals(object cl1)
    {
        if (cl1 is Client)
            return
                ((Client)cl1).num_client.Equals(this.num_client);
        else
            return false;
    }


}
