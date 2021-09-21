import React, { Component } from 'react';
let _urlApi = "https://localhost:5701";

function RemoverLocal(id) {
    fetch(_urlApi + '/api/excluir/' + id, {
        method: 'GET',
        //body: parametros,
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/x-www-form-urlencoded'
        },
    })
        .then(res => res.json())
        .then(json => json)
}

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            data: [], endereco: '', bairro: '', cep: '', numero: '', complemento: '', cidade: '', identificacao: '', capacidade: '', latitude: '', longitude: ''
        };
    }

    setEndereco = (event) => { this.setState({ endereco: event.target.value }); }
    setBairro = (event) => { this.setState({ bairro: event.target.value }) };
    setCEP = (event) => { this.setState({ cep: event.target.value }); }
    setNumero = (event) => { this.setState({ numero: event.target.value }) };
    setComplemento = (event) => { this.setState({ complemento: event.target.value }) };
    setCidade = (event) => { this.setState({ cidade: event.target.value }) };
    setIdentificacao = (event) => { this.setState({ identificacao: event.target.value }) };
    setCapacidade = (event) => { this.setState({ capacidade: event.target.value }) };
    setLatitude = (event) => { this.setState({ latitude: event.target.value }) };
    setLongitude = (event) => { this.setState({ longitude: event.target.value }) };

    submitLocal = e => {
        e.preventDefault();
        if (this.state.endereco === null || this.state.endereco === "") {
            alert("Necessário preenchimento Endereco");
            return;
        }
        if (this.state.bairro === null || this.state.bairro === "") {
            alert("Necessário preenchimento bairro");
            return;
        }

        if (this.state.numero === null || this.state.numero === "") {
            alert("Necessário preenchimento numero");
            return;
        }

        if (this.state.cep === null || this.state.cep === "") {
            alert("Necessário preenchimento CEP");
            return;
        }

        if (this.state.cidade === null || this.state.cidade === "") {
            alert("Necessário preenchimento cidade");
            return;
        }

        if (this.state.identificacao === null || this.state.identificacao === "") {
            alert("Necessário preenchimento identificacao");
            return;
        }

        if (this.state.capacidade === null || this.state.capacidade === "") {
            alert("Necessário preenchimento capacidade");
            return;
        }

        if (this.state.latitude === null || this.state.latitude === "") {
            alert("Necessário preenchimento latitude");
            return;
        }

        if (this.state.longitude === null || this.state.longitude === "") {
            alert("Necessário preenchimento longitude");
            return;
        }

        var parametros = "Logradouro=" + this.state.endereco + "&Bairro=" + this.state.bairro +
            "&NumeroEndereco=" + this.state.numero + "&CEP=" + this.state.cep + "&Complemento=" + this.state.complemento +
            "&Cidade=" + this.state.cidade + "&Identificacao=" + this.state.identificacao +
            "&Capacidade=" + this.state.capacidade + "&Latitude=" + this.state.latitude +
            "&Longitude=" + this.state.longitude;


        fetch(_urlApi + '/api/adicionar', {
            method: 'POST',
            body: parametros,
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/x-www-form-urlencoded'
            },
        })
            .then(res => {
                window.location.reload();
                res.json()
            })
            .then(json => json)
    }

    formularioToggle = () => {
        document.getElementById("form-reciclagem").style.display = "block";
    }

    componentDidMount() {
        fetch('https://localhost:44364/listar-todos')
            .then(response => {
                const resp = response.json();
                return resp;
            })
            .then((json) => {
                let jsonResult = json;
                this.setState({ data: jsonResult });
            });


    }

    render() {
        return (
            <div className="row">
                <div className="col-lg-12">
                <p>Para testar, por gentileza rodar a api primeiramente e depois rodar a aplicação web.
                Api: CsjSistemas.LocaisReciclagem.API</p>
                </div>

                <div className="col-lg-8">
                    <div className="row btn-adicionar">
                        <div className="col-md-2">
                            <button className="btn btn-info" onClick={this.formularioToggle}>Adicionar</button>
                        </div>
                    </div>
                    <form className="form-locais" id="form-reciclagem" onSubmit={this.submitLocal}>
                        <div className="row">
                            <div className="col-md-8">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Endereco" name="endereco" className="form-control" onChange={this.setEndereco} />
                                </div>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Bairro" name="bairro" className="form-control" onChange={this.setBairro} />
                                </div>
                            </div>
                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="CEP" name="cep" className="form-control" onChange={this.setCEP} />
                                </div>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Numero" name="numero" className="form-control" onChange={this.setNumero} />
                                </div>
                            </div>
                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Complemento" name="complemento" className="form-control" onChange={this.setComplemento} />
                                </div>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-md-8">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Cidade" name="cidade" className="form-control" onChange={this.setCidade} />
                                </div>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Identificacao" name="identificacao" className="form-control" onChange={this.setIdentificacao} />
                                </div>
                            </div>

                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Capacidade" name="capacidade" className="form-control" onChange={this.setCapacidade} />
                                </div>
                            </div>
                        </div>
                        <div className="row">
                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Latitude" name="latitude" className="form-control" onChange={this.setLatitude} />
                                </div>
                            </div>
                            <div className="col-md-4">
                                <div className="input-group mb-3">
                                    <input type="text" placeholder="Longitude" name="longitude" className="form-control" onChange={this.setLongitude} />
                                </div>
                            </div>
                        </div>

                        <div className="row">
                            <div className="col-md-4"></div>
                            <div className="col-md-2"></div>
                            <div className="col-md-2">
                                <input type="submit" defaultValue="Salvar" className="btn btn-success btn-submit" />
                            </div>
                        </div>

                    </form>
                </div>
                <table className="tat">
                    <thead>
                        <tr>
                            <th>Identificação</th>
                            <th>Descrição</th>
                            <th>Remover</th>
                        </tr>
                    </thead>
                    <tbody>
                        {
                            this.state.data.map((dynamicData, index) =>
                                <tr key={index}>
                                    <td>  {dynamicData.title}</td>
                                    <td> {dynamicData.description} </td>
                                    <td>
                                        <button className="btn btn-secondary" onClick={() => RemoverLocal(dynamicData.id)}>
                                            <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" className="bi bi-trash" viewBox="0 0 16 16">
                                                <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"></path>
                                                <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4 4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"></path>
                                            </svg>
                                        </button></td>
                                </tr>
                            )}
                    </tbody>

                </table>
            </div>

        );
    }
}

export default Home;
