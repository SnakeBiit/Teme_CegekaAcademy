import { connect } from 'react-redux';
import AlbumList from './AlbumList';
export default AlbumList;
export  default connect(mapStateToProps, mapDispatchToProps)(AlbumList);