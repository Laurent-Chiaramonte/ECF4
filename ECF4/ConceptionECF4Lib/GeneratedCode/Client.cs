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
    // Propriétés
    #region Propriétés
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
    #endregion

    // Constructeurs
    #region Constructeurs
    public Client (int numcli, string nomcli, string adrcli, int cpcli, string vilcli, string telcli)
    {
        num_client = numcli;
        nom_client = nomcli;
        adresse_client = adrcli;
        cp_client = cpcli;
        ville_client = vilcli;
        tel_client = telcli;
    }
    #endregion

    // Méthodes
    #region Méthodes
    public override string ToString()
    {
        return string.Format("Client : {0}, Raison sociale : {1}, Ville : {2}, Téléphone : {3}",
            num_client, nom_client, ville_client, tel_client);
    }

    public override bool Equals(object cl1)
    {
        if (cl1 is Client)
            return
                ((Client)cl1).num_client.Equals(this.num_client);
        else
            return false;
    }
    #endregion



}

