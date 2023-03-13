using Odata.DB;
using Odata.Models;
using Odata.Repository.Interfaces;
using System.Data.SQLite;

namespace Odata.Repository.Implementations;
public class PersonRepository : IPersonRepository {

    private SQLiteConnection sQLiteConnection;

    public PersonRepository() {
        this.sQLiteConnection = SQLiteDBConnection.getConnection();
    }

    public List<PersonModel> getPersons(int take) {
        List<PersonModel> personModels = new List<PersonModel>();
        SQLiteCommand command = sQLiteConnection.CreateCommand();
        command.CommandText = $"SELECT * FROM Pessoas limit {take}, 100";
        SQLiteDataReader reader = command.ExecuteReader();
        while (reader.Read()) {
            personModels.Add(new PersonModel {
                nome = reader.GetString(0),
                idade = reader.GetInt32(1),
                cpf = reader.GetString(2),
                rg = reader.GetString(3),
                data_nasc = reader.GetString(4),
                pai = reader.GetString(5),
                email = reader.GetString(6),
                senha = reader.GetString(7),
                cep = reader.GetString(8),
                endereco = reader.GetString(9),
                numero = reader.GetString(10),
                bairro = reader.GetString(11),
                cidade = reader.GetString(12),
                estado = reader.GetString(13),
                telefone_fixo = reader.GetString(14),
                celular = reader.GetString(15),
                altura = reader.GetFloat(16),
                peso = reader.GetFloat(17),
                tipo_sanguineo = reader.GetString(18),
                cor = reader.GetString(19)
            });
        }
        return personModels;
    }
}

