import React, { Component } from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { hotels: [], loading: true };
    }

    componentDidMount() {
        this.populateHotelData();
    }

    static renderHotelTable(hotels) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Resort</th>
                    </tr>
                </thead>
                <tbody>
                    {hotels.map(hotel =>
                        <tr key={hotel.rowKey}>
                            <td>{hotel.name}</td>
                            <td>{hotel.resortCode}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderHotelTable(this.state.hotels);

        return (
            <div>
                <h1 id="tabelLabel" >Hotels</h1>
                {contents}
            </div>
        );
    }

    async populateHotelData() {
        const response = await fetch('api/hotels');
        const data = await response.json();
        this.setState({ hotels: data, loading: false });
    }
}
