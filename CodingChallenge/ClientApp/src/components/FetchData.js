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

    static renderHotelTable(hotels, italianHotels) {
        return (
            <div>
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
                <table className='table table-striped' aria-labelledby="tabelLabel">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Resort</th>
                        </tr>
                    </thead>
                    <tbody>
                        {italianHotels.map((hotel, i) =>
                            <tr key={i}>
                                <td>{hotel.accommodation_Name}</td>
                                <td>{hotel.r_code}</td>
                            </tr>
                        )}
                    </tbody>
                </table>
            </div>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderHotelTable(this.state.hotels, this.state.italianHotels);

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

        const italianHotelResponse = await fetch('api/hotels/italian');
        const italianHotelData = await italianHotelResponse.json();
        this.setState({ hotels: data, italianHotels: italianHotelData, loading: false });
    }
}
